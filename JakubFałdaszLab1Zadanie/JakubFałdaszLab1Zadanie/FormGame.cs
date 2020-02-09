using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubFałdaszLab1Zadanie
{
    public partial class FormGame : Form
    {
        //zmienne odpowiadające za minutnik
        private int secondsLeft;
        private int minutesLeft;
        
        //obiekt klasy Random do generowania liczb pseudolosowych
        private Random rand;
        
        //zmienne przechowujące aktualne operandy wykorzystywane w działaniach
        private int operand1, operand2;
        //tablica przechowująca dostępne rodzaje działań
        private char[] operationSet = { '+', '-', '*' };
        //aktualne działanie
        private char currentOperation;
        
        //zmienna przechowująca aktualny poziom
        private int level;
        //aktualny wynik
        private int score;

        //zmienne przechowujące stan eventów (czy aktualnie trwają)
        private bool phoneCallActive;
        private bool energyEventActive;
        private bool foodEventActive;

        /// <summary>
        /// Konstruktor okna FormGame
        /// </summary>
        public FormGame()
        {
            InitializeComponent();

            //inicjalizacja obiektu Random
            rand = new Random();

            //początkowy czas
            secondsLeft = 0;
            minutesLeft = 1;
            //początkowy poziom i wynik
            level = 1;
            score = 0;

            //wszystkie eventy na początku gry są nieaktywne
            phoneCallActive = false;
            energyEventActive = false;
            foodEventActive = false;

            //uruchomienie i zatrzymanie odpowiednich timer'ów
            timerGame.Start();
            timerEndGame.Stop();
            timerPhoneCall.Stop();
            timerEnergy.Stop();
            timerFood.Stop();

            //stworzenie pierwszego obliczenia
            CreateNewOperation();

            //zablokowanie zmiany rozmiaru okna
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        /// <summary>
        /// Metoda wykonująca się co każdy "tick" zegara, "główna pętla gry"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGame_Tick(object sender, EventArgs e)
        {
            //zmniejsz czas o 1 sekundę
            DecreaseTimeLeft(1);
            
            //wyświetl zegar w odpowiednim formacie
            if (secondsLeft / 10 > 0)
                labelTimer.Text = minutesLeft + ":" + secondsLeft;
            else
                labelTimer.Text = minutesLeft + ":0" + secondsLeft;
                                   
            //Co sekunde zmniejszaj ilość energii, jedzenia i stan odebranych połączeń
            DecreaseProgressBar(progressBarEnergy, 1);
            DecreaseProgressBar(progressBarFood, 1);
            DecreaseProgressBar(progressBarPhoneCalls, 1);

            //Zmniejsz pozostały czas dla danego obliczenia 
            //(Ze względu na zwiększającą sie trudność obliczeń, im wyższy poziom tym dłuższy czas na wykonanie obliczenia)
            DecreaseProgressBar(progressBarTimeLeft, 20 - level);

            //Jeśli pozostały czas obliczenia jest równy 0, gracz otrzymuje karę
            if (progressBarTimeLeft.Value == 0)
                GivePenalty();

            //Przywrócenie odpowiedniego koloru obliczeń
            if (secondsLeft % 2 == 0)
            {
                labelOperation.ForeColor = Color.LawnGreen;
                textBoxResult.ForeColor = Color.LawnGreen;
            }

            //Wyświetlanie aktualnego poziomu i wyniku
            labelLevel.Text = "Poziom: " + level;
            labelScore.Text = "Wynik: " + score;

            //Jeśli skończy się czas gry lub któryś z pasków wytrzymałości,
            //następuje zatrzymanie timer'ów i wyświetlenie komunikatu "GAME OVER"
            if((minutesLeft == 0 && secondsLeft == 0 ) || progressBarEnergy.Value == 0 || progressBarFood.Value == 0 || progressBarPhoneCalls.Value == 0)
            {
                timerGame.Stop();
                timerEnergy.Stop();
                timerPhoneCall.Stop();
                timerFood.Stop();
                timerEndGame.Start();
            }

            //Jeśli metoda .Next() zwróci wartość 9 zostanie rozpoczęty odpowiedni event
            if(rand.Next(0,10) == 9 && phoneCallActive == false)
            {
                StartPhoneCallEvent();
            }
            if (rand.Next(0, 10) == 9 && energyEventActive == false)
            {
                StartEnergyEvent();
            }
            if (rand.Next(0, 10) == 9 && foodEventActive == false)
            {
                StartFoodEvent();
            }

        }

        /// <summary>
        /// Metoda losuje jedna z trzech dostepnych operacji (+, -, *)
        /// </summary>
        /// <returns></returns>
        private char GetNextOperation()
        {
            int nextIndex = rand.Next(0, 3);
            return operationSet[nextIndex];
        }

        /// <summary>
        /// Zwraca losową wartość wykorzystywaną w działaniu. Zmienia przedział losowania w zależnosci od poziomu i rodzaju działania
        /// </summary>
        /// <returns></returns>
        private int GetNextOperand()
        {
           if(level < 4)
            {
                if (currentOperation == '*')
                    return rand.Next(0, level*3);
                else
                    return rand.Next(0 + (level - 1 * 10), 10 * level);
            } else
            {
                if(currentOperation == '*')
                    return rand.Next(0, level*3);
                else
                    return rand.Next(-10 * level, 10 * level);
            }
        }

        /// <summary>
        /// Składa rodzaj operacji oraz operandy i wyświetla je w w labelOperation
        /// </summary>
        private void CreateNewOperation()
        {
            currentOperation = GetNextOperation();
            operand1 = GetNextOperand();
            operand2 = GetNextOperand();
            labelOperation.Text = operand1 + " " + currentOperation + " " + operand2;
        }

        /// <summary>
        /// Zatwierdza wprowadzoną wartość w polu tekstowym po naciśnięcu klawisza Enter.
        /// Jeśli gra jest skończona, po naciśnięciu inicjalizowana jest nowa rozgrywka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxResult_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && timerGame.Enabled)
            {
                int result;
                //przechwycenie wyjątku jeśli gracz wprowadzi w polu tekstowym inną wartość niż liczba
                try
                {
                    result = Int32.Parse(textBoxResult.Text);
                }
                catch (Exception exc)
                {
                    GivePenalty();
                    e.Handled = true;
                    return;
                }

                //Wybranie odpowiedniej operacji i przyznanie kary lub nagrody w zależności od poprawnego wyniku
                switch (currentOperation)
                {
                    case '+':
                        if (operand1 + operand2 != result)
                            GivePenalty();
                        else
                            GiveReward();
                        break;
                    case '-':
                        if (operand1 - operand2 != result)
                            GivePenalty();
                        else
                            GiveReward();
                        break;
                    case '*':
                        if (operand1 * operand2 != result)
                            GivePenalty();
                        else
                            GiveReward();
                        break;
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                //Zainicjowanie nowej gry
                score = 0;
                minutesLeft = 1;
                secondsLeft = 0;
                StopEnergyEvent();
                StopFoodEvent();
                StopPhoneCallEvent();
                IncreaseProgressBar(progressBarEnergy, 100);
                IncreaseProgressBar(progressBarFood, 100);
                IncreaseProgressBar(progressBarPhoneCalls, 100);
                level = 1;
                CreateNewOperation();
                labelGameOver.Visible = false;
                labelRestart.Visible = false;
                timerEndGame.Stop();
                timerGame.Start();
                e.Handled = true;
            }
        }

        /// <summary>
        /// Zmniejszenie poziomu
        /// </summary>
        private void LowerLevel()
        {
            if (level > 1)
                level--;
        }

        /// <summary>
        /// Przyznanie kary:
        /// -Obnizenie poziomu
        /// -Zmiana koloru operandów na czerwony
        /// -Zmniejszenie pozostałego czasu o 5 sekund
        /// -Zmniejszenie pozostałej energii, jedzenia oraz wskaźnika połączeń telefonicznych
        /// -Zainicjowanie nowego obliczenia
        /// </summary>
        private void GivePenalty()
        {
            LowerLevel();
            labelOperation.ForeColor = Color.Red;
            textBoxResult.ForeColor = Color.Red;

            DecreaseTimeLeft(5);

            DecreaseProgressBar(progressBarEnergy, 10);
            DecreaseProgressBar(progressBarFood, 10);
            DecreaseProgressBar(progressBarPhoneCalls, 10);

            progressBarTimeLeft.Value = 100;

            textBoxResult.Text = "";
            CreateNewOperation();
        }

        /// <summary>
        /// Przyznanie nagrody:
        /// -Zwiekszenie poziomu
        /// -Dodanie 5 punktow
        /// -Dodanie 2pkt do kazdego z zasobów
        /// -Zwiekszenie pozostalego czasu
        /// -Zmiana koloru operandów na niebieski
        /// -Zainicjowanie nowego obliczenia
        /// </summary>
        private void GiveReward()
        {
            level++;
            score += 5;
            IncreaseTimeLeft(5);
            labelOperation.ForeColor = Color.Blue;
            textBoxResult.ForeColor = Color.Blue;

            progressBarTimeLeft.Value = 100;

            IncreaseProgressBar(progressBarEnergy, 2);
            IncreaseProgressBar(progressBarPhoneCalls, 2);
            IncreaseProgressBar(progressBarFood, 2);

            textBoxResult.Text = "";
            CreateNewOperation();
        }

        /// <summary>
        /// Metoda zmniejsza długość progressBar o wartość value
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="value"></param>
        private void DecreaseProgressBar(ProgressBar pb, int value)
        {
            if (pb.Value - value < 0)
                pb.Value = 0;
            else
                pb.Value -= value;
        }
        
        /// <summary>
        /// Metoda zwiększa długość progressBar o wartość value
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="value"></param>
        private void IncreaseProgressBar(ProgressBar pb, int value)
        {
            if (pb.Value + value > 100)
                pb.Value = 100;
            else
                pb.Value += value;
        }

        /// <summary>
        /// Metoda zmniejsza pozostały czas o wartość value
        /// </summary>
        /// <param name="value"></param>
        private void DecreaseTimeLeft(int value)
        {
            if (minutesLeft == 0 && secondsLeft - value < 0)
            {
                minutesLeft = 0;
                secondsLeft = 0;
            }
            else if (minutesLeft > 0 && secondsLeft - value < 0)
            {
                minutesLeft--;
                secondsLeft = 60 - secondsLeft - value;
            }
            else
                secondsLeft -= value;
        }

        /// <summary>
        /// Metoda zwiększa pozostały czas o wartość value
        /// </summary>
        /// <param name="value"></param>
        private void IncreaseTimeLeft(int value)
        {
            if ( secondsLeft + value > 59)
            {
                minutesLeft++;
                secondsLeft = 59 - secondsLeft + value;
            }
            else
                secondsLeft += value;
        }

        /// <summary>
        /// Wyświetla wiadomość "GAME OVER"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEndGame_Tick(object sender, EventArgs e)
        {
            if (labelGameOver.Visible)
            {
                labelRestart.Visible = false;
                labelGameOver.Visible = false;
            }
            else
            {
                labelRestart.Visible = true;
                labelGameOver.Visible = true;
            }
             
        }

        /// <summary>
        /// Rozpoczęcie eventu phoneCall
        /// </summary>
        private void StartPhoneCallEvent()
        {
            phoneCallActive = true;
            timerPhoneCall.Start();
            progressBarAnswerCall.Value = 100;
            progressBarAnswerCall.Visible = true;
            buttonPhoneAnswerGlowing.Visible = true;
            labelGlowingPhone.Visible = true;
        }

        /// <summary>
        /// Zatrzymanie eventu phoneCall
        /// </summary>
        private void StopPhoneCallEvent()
        {
            phoneCallActive = false;
            timerPhoneCall.Stop();
            progressBarAnswerCall.Visible = false;
            buttonPhoneAnswerGlowing.Visible = false;
            labelGlowingPhone.Visible = false;
            GainFocusOnResultInput();
        }
        
        /// <summary>
        /// Po klknięciu w przycisk na telefonie zostaną przyznane punkty oraz zakończenie phoneCallevent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPhoneAnswerGlowing_Click(object sender, EventArgs e)
        {
            if(phoneCallActive)
            {
                score++;
                StopPhoneCallEvent();
                IncreaseProgressBar(progressBarPhoneCalls, 10);
            }
        }

        /// <summary>
        /// Po upłynięciu określonego czasu phoneCallEvent zostaje zakończony
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPhoneCall_Tick(object sender, EventArgs e)
        {
            progressBarAnswerCall.Value -= 5;

            if (progressBarAnswerCall.Value == 0)
            {
                StopPhoneCallEvent();
                DecreaseProgressBar(progressBarPhoneCalls, 10);
            }

            if (labelGlowingPhone.Visible)
                labelGlowingPhone.Visible = false;
            else
                labelGlowingPhone.Visible = true;
        }

        /// <summary>
        /// Po upłynięciu określonego czasu energyEvent zostaje zakończony
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEnergy_Tick(object sender, EventArgs e)
        {
            progressBarEnergyEvent.Value -= 5;

            if (progressBarEnergyEvent.Value == 0)
            {
                StopEnergyEvent();
                DecreaseProgressBar(progressBarEnergy, 10);
            }
        }

        /// <summary>
        /// Po klknięciu w przycisk na kubku zostaną przyznane punkty oraz zakończenie energyEvent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnergy_Click(object sender, EventArgs e)
        {
            if(energyEventActive)
            {
                score++;
                StopEnergyEvent();
                IncreaseProgressBar(progressBarEnergy, 10);
            }
        }

        /// <summary>
        /// Rozpoczęcie energyEvent
        /// </summary>
        private void StartEnergyEvent()
        {
            energyEventActive = true;
            timerEnergy.Start();
            progressBarEnergyEvent.Value = 100;
            progressBarEnergyEvent.Visible = true;
            buttonEnergy.Visible = true;
        }

        /// <summary>
        /// Zakończenie energyEvent
        /// </summary>
        private void StopEnergyEvent()
        {
            buttonEnergy.Visible = false;
            energyEventActive = false;
            timerEnergy.Stop();
            progressBarEnergyEvent.Visible = false;
            buttonEnergy.Visible = false;
            GainFocusOnResultInput();
        }

        /// <summary>
        /// Rozpoczęcie foodEvent
        /// </summary>
        private void StartFoodEvent()
        {
            foodEventActive = true;
            timerFood.Start();
            progressBarFoodEvent.Value = 100;
            progressBarFoodEvent.Visible = true;
            buttonFood.Visible = true;
        }

        /// <summary>
        /// Zakończenie foodEvent
        /// </summary>
        private void StopFoodEvent()
        {
            buttonFood.Visible = false;
            foodEventActive = false;
            timerFood.Stop();
            progressBarFoodEvent.Visible = false;
            buttonFood.Visible = false;
            GainFocusOnResultInput();
        }

        /// <summary>
        /// Po upłynięciu określonego czasu foodEvent zostaje zakończony
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFood_Tick(object sender, EventArgs e)
        {
            progressBarFoodEvent.Value -= 5;

            if (progressBarFoodEvent.Value == 0)
            {
                StopFoodEvent();
                DecreaseProgressBar(progressBarFood, 10);
            }
        }

        /// <summary>
        /// Po klknięciu w przycisk na hambuergerze zostaną przyznane punkty oraz zakończenie foodEvent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFood_Click(object sender, EventArgs e)
        {
            if (foodEventActive)
            {
                score++;
                StopFoodEvent();
                IncreaseProgressBar(progressBarFood, 10);
            }
        }

        /// <summary>
        /// Ustaw focus na textBoxResult
        /// </summary>
        private void GainFocusOnResultInput()
        {
            textBoxResult.Select();
            textBoxResult.Focus();
        }

        /// <summary>
        /// Zakończenie programu po zamknięciu okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Przycisk powrotu do menu głównego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            formMain.Location = this.Location;
            this.Hide();
        }
    }
}
