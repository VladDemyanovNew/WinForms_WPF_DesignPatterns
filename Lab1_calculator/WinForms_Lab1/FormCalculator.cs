using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDemyanov.WinFormsLab1.Domain;
using System.Windows.Forms;

namespace VDemyanov.WinFormsLab1.WinForms
{
    public partial class FormCalculator : Form
    {
        private Calculator calculator;
        private Dictionary<string, bool> buttonsStates;
        private bool MRC_counter = true;
        public FormCalculator()
        {
            InitializeComponent();
            calculator = new Calculator();
            buttonsStates = new Dictionary<string, bool>()
            {                
                // + - * /
                { buttonSub.ToString(), true },
                { buttonSum.ToString(), true },
                { buttonDiv.ToString(), true },
                { buttonMul.ToString(), true },
                // sin cos tg ctg
                { buttonSin.ToString(), true },
                { buttonCos.ToString(), true },
                { buttonTg.ToString(), true },
                { buttonCtg.ToString(), true },
                // операции со степенью
                { buttonSqrtX.ToString(), true },
                { buttonSqrt.ToString(), true },
                { buttonDegreeX.ToString(), true },
                { buttonSq.ToString(), true }
            };
            Display.Text = "0";
        }

        /// <summary>
        /// Проверка на активность кнопок для операций
        /// </summary>
        private bool CheckButtons()
        {
            // + - * /
            if (!buttonsStates[buttonSub.ToString()])
                return false;
            else if (!buttonsStates[buttonSum.ToString()])
                return false;
            else if (!buttonsStates[buttonDiv.ToString()])
                return false;
            else if (!buttonsStates[buttonMul.ToString()])
                return false;
            // sin cos tg ctg
            else if (!buttonsStates[buttonSin.ToString()])
                return false;
            else if (!buttonsStates[buttonCos.ToString()])
                return false;
            else if (!buttonsStates[buttonTg.ToString()])
                return false;
            else if (!buttonsStates[buttonCtg.ToString()])
                return false;
            // операции со степенью
            else if (!buttonsStates[buttonSqrtX.ToString()])
                return false;
            else if (!buttonsStates[buttonSqrt.ToString()])
                return false;
            else if (!buttonsStates[buttonDegreeX.ToString()])
                return false;
            else if (!buttonsStates[buttonSq.ToString()])
                return false;
            return true;
        }

        /// <summary>
        /// Освободить состояния кнопок
        /// </summary>
        private void FreeButtons()
        {
            // + - * /
            buttonsStates[buttonSub.ToString()] = true;
            buttonsStates[buttonSum.ToString()] = true;
            buttonsStates[buttonDiv.ToString()] = true;
            buttonsStates[buttonMul.ToString()] = true;
            // sin cos tg ctg
            buttonsStates[buttonSin.ToString()] = true;
            buttonsStates[buttonCos.ToString()] = true;
            buttonsStates[buttonTg.ToString()] = true;
            buttonsStates[buttonCtg.ToString()] = true;
            // операции со степенью
            buttonsStates[buttonSqrtX.ToString()] = true;
            buttonsStates[buttonSqrt.ToString()] = true;
            buttonsStates[buttonDegreeX.ToString()] = true;
            buttonsStates[buttonSq.ToString()] = true;
        }

        /// <summary>
        /// Нажатие на цифры
        /// </summary>
        private void Button22_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (Display.Text == "0")
            {
                Display.Text = button.Text;
            }                
            else
            {
                Display.Text += button.Text;
            }                
        }

        /// <summary>
        /// Нажатие на кнопку очистки
        /// </summary>
        private void ButtonC_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
            FreeButtons();
        }

        /// <summary>
        /// Нажатие на кнопку ","
        /// </summary>        
        private void ButtonComma_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!Display.Text.Contains(","))
                Display.Text += button.Text;
        }

        /*
         * Арифметические операции + - * /
         */

        /// <summary>
        /// Нажатие на кнопку "+"
        /// </summary>
        private void ButtonSum_Click(object sender, EventArgs e)
        {
            if (CheckButtons())
            {                
                calculator.PushX(Convert.ToDouble(Display.Text));
                buttonsStates[buttonSum.ToString()] = false;
                Display.Text = "0";
            }
            else
            {
                ButtonCalculate_Click(null, null);
                calculator.PushX(Convert.ToDouble(Display.Text));
                buttonsStates[buttonSum.ToString()] = false;
                Display.Text = "0";
            }
        }

        /// <summary>
        /// Нажатие на кнопку "-"
        /// </summary>
        private void ButtonSub_Click(object sender, EventArgs e)
        {
            if (CheckButtons())
            {
                calculator.PushX(Convert.ToDouble(Display.Text));
                buttonsStates[buttonSub.ToString()] = false;
                Display.Text = "0";
            }
            else
            {
                ButtonCalculate_Click(null, null);
                calculator.PushX(Convert.ToDouble(Display.Text));
                buttonsStates[buttonSub.ToString()] = false;
                Display.Text = "0";
            }
        }

        /// <summary>
        /// Нажатие на кнопку "*"
        /// </summary>
        private void ButtonMul_Click(object sender, EventArgs e)
        {
            if (CheckButtons())
            {
                calculator.PushX(Convert.ToDouble(Display.Text));
                buttonsStates[buttonMul.ToString()] = false;
                Display.Text = "0";
            }
            else
            {
                ButtonCalculate_Click(null, null);
                calculator.PushX(Convert.ToDouble(Display.Text));
                buttonsStates[buttonMul.ToString()] = false;
                Display.Text = "0";
            }
        }

        /// <summary>
        /// Нажатие на кнопку "/"
        /// </summary>
        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            if (CheckButtons())
            {
                calculator.PushX(Convert.ToDouble(Display.Text));
                buttonsStates[buttonDiv.ToString()] = false;
                Display.Text = "0";
            }
            else
            {
                ButtonCalculate_Click(null, null);
                calculator.PushX(Convert.ToDouble(Display.Text));
                buttonsStates[buttonDiv.ToString()] = false;
                Display.Text = "0";
            }
        }

        /*
         * Тригонометрические операции sin cos tg ctg
         */

        /// <summary>
        /// Нажатие на кнопку "sin"
        /// </summary>
        private void ButtonSin_Click(object sender, EventArgs e)
        {
            if (CheckButtons())
            {
                calculator.PushX(Convert.ToDouble(Display.Text));
                Display.Text = calculator.Calc_sin(Convert.ToDouble(Display.Text)).ToString();
                FreeButtons();
                calculator.ClearResult();
            }
            else
            {
                Display.Text = calculator.Calc_sin(Convert.ToDouble(Display.Text)).ToString();
                ButtonCalculate_Click(null, null);
                calculator.PushX(Convert.ToDouble(Display.Text));                
                FreeButtons();
                calculator.ClearResult();
            }
        }

        /// <summary>
        /// Нажатие на кнопку "cos"
        /// </summary>
        private void ButtonCos_Click(object sender, EventArgs e)
        {
            if (CheckButtons())
            {
                calculator.PushX(Convert.ToDouble(Display.Text));
                Display.Text = calculator.Calc_cos(Convert.ToDouble(Display.Text)).ToString();
                FreeButtons();
                calculator.ClearResult();
            }
            else
            {
                Display.Text = calculator.Calc_cos(Convert.ToDouble(Display.Text)).ToString();
                ButtonCalculate_Click(null, null);
                calculator.PushX(Convert.ToDouble(Display.Text));
                FreeButtons();
                calculator.ClearResult();
            }
        }

        /// <summary>
        /// Нажатие на кнопку "tg"
        /// </summary>
        private void ButtonTg_Click(object sender, EventArgs e)
        {
            if (CheckButtons())
            {
                calculator.PushX(Convert.ToDouble(Display.Text));
                Display.Text = calculator.Calc_tg(Convert.ToDouble(Display.Text)).ToString();
                FreeButtons();
                calculator.ClearResult();
            }
            else
            {
                Display.Text = calculator.Calc_tg(Convert.ToDouble(Display.Text)).ToString();
                ButtonCalculate_Click(null, null);
                calculator.PushX(Convert.ToDouble(Display.Text));
                FreeButtons();
                calculator.ClearResult();
            }
        }

        /// <summary>
        /// Нажатие на кнопку "ctg"
        /// </summary>
        private void ButtonCtg_Click(object sender, EventArgs e)
        {
            if (CheckButtons())
            {
                calculator.PushX(Convert.ToDouble(Display.Text));
                Display.Text = calculator.Calc_ctg(Convert.ToDouble(Display.Text)).ToString();
                FreeButtons();
                calculator.ClearResult();
            }
            else
            {
                Display.Text = calculator.Calc_ctg(Convert.ToDouble(Display.Text)).ToString();
                ButtonCalculate_Click(null, null);
                calculator.PushX(Convert.ToDouble(Display.Text));
                FreeButtons();
                calculator.ClearResult();
            }
        }

        /*
         * Операции со степенью
         */

        /// <summary>
        /// Нажатие на кнопку "SqrtX"
        /// </summary>        
        private void ButtonSqrtX_Click(object sender, EventArgs e)
        {
            if (CheckButtons())
            {
                calculator.PushX(Convert.ToDouble(Display.Text));
                buttonsStates[buttonSqrtX.ToString()] = false;
                Display.Text = "0";
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Sqrt"
        /// </summary>        
        private void ButtonSqrt_Click(object sender, EventArgs e)
        {
            if (CheckButtons())
            {
                calculator.PushX(Convert.ToDouble(Display.Text));
                Display.Text = calculator.Calc_sqrt(Convert.ToDouble(Display.Text)).ToString();
                FreeButtons();
                calculator.ClearResult();
            }
            else
            {
                Display.Text = calculator.Calc_sqrt(Convert.ToDouble(Display.Text)).ToString();
                ButtonCalculate_Click(null, null);
                calculator.PushX(Convert.ToDouble(Display.Text));
                FreeButtons();
                calculator.ClearResult();
            }
        }

        /// <summary>
        /// Нажатие на кнопку "DegreeX"
        /// </summary>        
        private void ButtonDegreeX_Click(object sender, EventArgs e)
        {
            if (CheckButtons())
            {
                calculator.PushX(Convert.ToDouble(Display.Text));
                buttonsStates[buttonDegreeX.ToString()] = false;
                Display.Text = "0";
            }
        }

        /// <summary>
        /// Нажатие на кнопку "Sq"
        /// </summary>        
        private void ButtonSq_Click(object sender, EventArgs e)
        {
            if (CheckButtons())
            {
                calculator.PushX(Convert.ToDouble(Display.Text));
                Display.Text = calculator.Calc_sq(Convert.ToDouble(Display.Text)).ToString();
                FreeButtons();
                calculator.ClearResult();
            }
            else
            {
                Display.Text = calculator.Calc_sq(Convert.ToDouble(Display.Text)).ToString();
                ButtonCalculate_Click(null, null);
                calculator.PushX(Convert.ToDouble(Display.Text));
                FreeButtons();
                calculator.ClearResult();
            }
        }

        /*
         * Операции хранения
         */

        /// <summary>
        /// Добавить к хранилищу
        /// </summary>        
        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            calculator.Memory_plus(Convert.ToDouble(Display.Text));
        }

        /// <summary>
        /// Вычесть из хранилища
        /// </summary>        
        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            calculator.Memory_minus(Convert.ToDouble(Display.Text));
        }

        /// <summary>
        /// (Вывести / Очистить) хранилище
        /// </summary>
        private void buttonMRC_Click(object sender, EventArgs e)
        {
            if (MRC_counter)
            {
                if (Display.Text == "0")
                    Display.Text = calculator.Show_MRC().ToString();
                else
                    Display.Text += calculator.Show_MRC();
                MRC_counter = false;
            }
            else
            {
                calculator.Clear_MRC();
                MRC_counter = true;
            }
            
        }

        /// <summary>
        /// Нажатие на кнопку "="
        /// </summary>
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            // + - * /
            if (!buttonsStates[buttonSub.ToString()])
            {
                Display.Text = calculator.Calc_sub(Convert.ToDouble(Display.Text)).ToString();
            }
            else if (!buttonsStates[buttonSum.ToString()])
            {
                Display.Text = calculator.Calc_sum(Convert.ToDouble(Display.Text)).ToString();
            }                
            else if (!buttonsStates[buttonDiv.ToString()])
            {
                Display.Text = calculator.Calc_div(Convert.ToDouble(Display.Text)).ToString();
            }
            else if (!buttonsStates[buttonMul.ToString()])
            {
                Display.Text = calculator.Calc_mul(Convert.ToDouble(Display.Text)).ToString();
            }
            // sin cos tg ctg
            else if (!buttonsStates[buttonSin.ToString()])
            {
                Display.Text = calculator.Calc_sin(Convert.ToDouble(Display.Text)).ToString();
            }
            else if (!buttonsStates[buttonCos.ToString()])
            {
                Display.Text = calculator.Calc_cos(Convert.ToDouble(Display.Text)).ToString();
            }
            else if (!buttonsStates[buttonTg.ToString()])
            {
                Display.Text = calculator.Calc_tg(Convert.ToDouble(Display.Text)).ToString();
            }
            else if (!buttonsStates[buttonCtg.ToString()])
            {
                Display.Text = calculator.Calc_ctg(Convert.ToDouble(Display.Text)).ToString();
            }
            // операции со степенью
            else if (!buttonsStates[buttonSqrtX.ToString()])
            {
                Display.Text = calculator.Calc_sqrtX(Convert.ToDouble(Display.Text)).ToString();
            }                 
            else if (!buttonsStates[buttonDegreeX.ToString()])
            {
                Display.Text = calculator.Calc_degreeX(Convert.ToDouble(Display.Text)).ToString();
            }
            else if (!buttonsStates[buttonSqrt.ToString()])
            {
                Display.Text = calculator.Calc_sqrt(Convert.ToDouble(Display.Text)).ToString();
            }
            else if (!buttonsStates[buttonSq.ToString()])
            {
                Display.Text = calculator.Calc_sq(Convert.ToDouble(Display.Text)).ToString();
            }

            calculator.ClearResult();
            FreeButtons();
        }

        /// <summary>
        /// Удаление последнего символа
        /// </summary>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (Display.Text.Length != 1)
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
            }
            else
            {
                Display.Text = "0";
            }
        }
    }
}
