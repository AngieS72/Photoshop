using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Photoshop.MattedPhoto;
using static Photoshop.FramedPhoto;

namespace Photoshop
{
    public partial class FormPhotoShop : Form
    {
        public FormPhotoShop()
        {
            InitializeComponent();
        }

        //Global Variables
        bool valid = false;
        float width = 0.00f;
        float height = 0.00f;
        Photo photo = null;
        string photoType = "";

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearWidthAndHeight();
            clearFrameRadioButtons();
            clearColorRadioButtons();
            clearMaterialRadioButtons();
            clearStyleRadioButtons();
            clearLabels();
        }

        private void clearWidthAndHeight()
        {
            textBoxWidth.Text = "";
            textBoxHeight.Text = "";
            textBoxWidth.Focus();
        }

        public void clearFrameRadioButtons()
        {
            radioButtonUnframed.Checked = false;
            radioButtonFramed.Checked = false;
            radioButtonMatted.Checked = false;
            groupBoxFrame.Enabled = true;
        }

        public void clearColorRadioButtons()
        {
            radioButtonBlack.Checked = false;
            radioButtonRed.Checked = false;
            radioButtonGreen.Checked = false;
            radioButtonBlue.Checked = false;
            radioButtonWhite.Checked = false;
            groupBoxColor.Enabled = true;
        }

        public void clearMaterialRadioButtons()
        {
            radioButtonPine.Checked = false;
            radioButtonOak.Checked = false;
            radioButtonSteel.Checked = false;
            radioButtonSilver.Checked = false;
            radioButtonGold.Checked = false;
            groupBoxMaterial.Enabled = true;
        }

        private void clearStyleRadioButtons()
        {
            radioButtonSimple.Checked = false;
            radioButtonModern.Checked = false;
            radioButtonAntique.Checked = false;
            radioButtonVintage.Checked = false;
            radioButtonEclectic.Checked = false;
            groupBoxStyle.Enabled = true;
        }

        private void clearLabels()
        {
            labelCostQuote.Text = "";
            labelOrderDescription.Text = "";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            bool keepGoing = validateWidth();

            if (keepGoing)
            {
                validateHeight();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                validateFrame();
            }
            else
            {
                return;
            }

            calculatePrice();

        }

        private bool validateWidth()
        {
            float theWidth;

            if (textBoxWidth.Text == "")
            {
                showMessageBox("Width Field Cannot Be Blank",
                                                "BLANK WIDTH FIELD!");
                textBoxWidth.Focus();
                return false;
            }

            valid = float.TryParse(textBoxWidth.Text, out theWidth);

            if (!(valid))
            {
                showMessageBox("Width Must Be Numeric Entry.",
                                                "NON-NUMERIC ENTRY");
                textBoxWidth.Text = "";
                textBoxWidth.Focus();
                return false;
            }          

            if (theWidth <= 0)
            {
                showMessageBox("Width Entry must be greater than 0.",
                                                "NEGATIVE ENTRY");
                textBoxWidth.Text = "";
                textBoxWidth.Focus();
                return false;
            }

            return true;
        }

        private bool validateHeight()
        {
            float theHeight;

            if (textBoxHeight.Text == "")
            {
                showMessageBox("Width Field Cannot Be Blank",
                                                "BLANK WIDTH FIELD!");
                textBoxHeight.Focus();
                return false;
            }

            valid = float.TryParse(textBoxHeight.Text, out theHeight);

            if (!(valid))
            {
                showMessageBox("Height Must Be Numeric Entry.",
                                                "NON-NUMERIC ENTRY");
                textBoxHeight.Text = "";
                textBoxHeight.Focus();
                return false;
            }            

            if (theHeight <= 0)
            {
                showMessageBox("Width Entry must be greater than 0.",
                                                "NEGATIVE ENTRY");
                textBoxHeight.Text = "";
                textBoxHeight.Focus();
                return false;
            }

            return true;
        }

        private bool validateMaterial()
        {
            if ((radioButtonPine.Checked == false &&
                radioButtonOak.Checked == false &&
                radioButtonSteel.Checked == false &&
                radioButtonSilver.Checked == false &&
                radioButtonGold.Checked == false))
            {
                showMessageBox("No radiobutton chosen for Material!",
                                                "NO MATERIAL RADIO BUTTON");
                return false;
            }
            return true;
        }

        private bool validateFrame()
        {
            if ((radioButtonFramed.Checked == false &&
                radioButtonMatted.Checked == false &&
                radioButtonUnframed.Checked == false))
            {
                showMessageBox("No radio button chosen for Frame!",
                                                "NO FRAME RADIO BUTTON");
                return false;
            }

            return true;
        }

        private void calculatePrice()
        {
            width = Convert.ToSingle(textBoxWidth.Text);
            height = Convert.ToSingle(textBoxHeight.Text);

            if (radioButtonUnframed.Checked)
            {
                setUnframedOptions();

                photoType = "Unframed";

                photo = new Photo(width, height);
            }
            else if (radioButtonMatted.Checked)
            {
                setMattedOptions();
                valid = validateColor();

                if (!valid)
                {
                    return;
                }

                findOutColorChecked();
            }
            else if (radioButtonFramed.Checked)
            {
                setFramedOptions();
                valid = validateMaterial();

                if (!valid)
                {
                    return;
                }

                valid = validateStyle();

                if (!valid)
                {
                    return;
                }

                FindOutMaterialAndStyle();
            }

            setBill();
        }

        private void setUnframedOptions()
        {
            groupBoxColor.Enabled = false;
            groupBoxMaterial.Enabled = false;
            groupBoxStyle.Enabled = false;
        }

        private void setMattedOptions()
        {
            groupBoxColor.Enabled = true;
            groupBoxMaterial.Enabled = false;
            groupBoxStyle.Enabled = false;
        }

        private void setFramedOptions()
        {
            groupBoxColor.Enabled = false;
            groupBoxMaterial.Enabled = true;
            groupBoxStyle.Enabled = true;
        }

        private void findOutColorChecked()
        {
            RadioButton[] options = new RadioButton[] {radioButtonBlack,
                                                                                   radioButtonRed,
                                                                                    radioButtonGreen,
                                                                                    radioButtonBlue,
                                                                                    radioButtonWhite};

            foreach (RadioButton radio in options)
            {
                if (radio.Checked)
                {
                    switch (radio.Name)
                    {
                        case "radioButtonBlack":
                            photo = new MattedPhoto(width, height, Colors.BLACK);
                            break;
                        case "radioButtonRed":
                            photo = new MattedPhoto(width, height, Colors.RED);
                            break;
                        case "radioButtonGreen":
                            photo = new MattedPhoto(width, height, Colors.GREEN);
                            break;
                        case "radioButtonBlue":
                            photo = new MattedPhoto(width, height, Colors.BLUE);
                            break;
                        case "radioButtonWhite":
                            photo = new MattedPhoto(width, height, Colors.WHITE);
                            break;
                            ;
                    }
                }
            }

            photoType = "Matted";
        }

        private void FindOutMaterialAndStyle()
        {
            Materials? material = null;
            Styles? style = null;

            RadioButton[] optionsMaterial = new RadioButton[]
            {
                radioButtonPine,
                radioButtonOak,
                radioButtonSteel,
                radioButtonSilver,
                radioButtonGold
            };

            RadioButton[] optionsStyle = new RadioButton[]
            {
                radioButtonSimple,
                radioButtonModern,
                radioButtonAntique,
                radioButtonVintage,
                radioButtonEclectic
            };

            foreach (RadioButton radio in optionsMaterial)
            {
                if (radio.Checked)
                {
                    switch (radio.Name)
                    {
                        case "radioButtonPine":
                            material = Materials.PINE;
                            break;
                        case "radioButtonOak":
                            material = Materials.OAK;
                            break;
                        case "radioButtonSttel":
                            material = Materials.STEEL;
                            break;
                        case "radioButtonSilver":
                            material = Materials.SILVER;
                            break;
                        case "radioButtonGold":
                            material = Materials.GOLD;
                            break;
                    }
                }
            }
            foreach (RadioButton radio in optionsStyle)
            {
                if (radio.Checked)
                {
                    switch (radio.Name)
                    {
                        case "radioButtonSimple":
                            style = Styles.SIMPLE;
                            break;
                        case "radioButtonModern":
                            style = Styles.MODERN;
                            break;
                        case "radioButtonAntique":
                            style = Styles.ANTIQUE;
                            break;
                        case "radioButtonVintage":
                            style = Styles.VINTAGE;
                            break;
                        case "radioButtonEclectic":
                            style = Styles.ECLECTIC;
                            break;
                    }
                }
            }

            photo = new FramedPhoto(width, height, (Materials)material, (Styles)style);
            photoType = "Framed";
        }

        private bool validateColor()
        {
            if ((radioButtonBlack.Checked == false &&
                radioButtonRed.Checked == false &&
                radioButtonGreen.Checked == false &&
                radioButtonBlue.Checked == false &&
                radioButtonWhite.Checked == false))
            {
                showMessageBox("No radio button chosen for Color!",
                                                "NO COLOR RADIO BUTTON");
                return false;
            }

            return true;
        }

        private bool validateStyle()
        {
            if ((radioButtonSimple.Checked == false) &&
                (radioButtonModern.Checked == false) &&
                (radioButtonAntique.Checked == false) &&
                (radioButtonVintage.Checked == false) &&
                (radioButtonEclectic.Checked == false))
            {
                showMessageBox("No style button chosen for Style!",
                                                "NO STYLE RADIO BUTTON");
                return false;
            }
            return true;
        }

        private void showMessageBox(string text, string title)
        {
            MessageBox.Show(text, title,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
        }

        private void setBill()
        {
            switch (photoType)
            {
                case "Unframed":
                    labelCostQuote.Text = "Cost:  " + photo.Price.ToString("C");
                    labelOrderDescription.Text = photo.ToString();
                    break;

                case "Matted":
                    labelCostQuote.Text = "Cost:  " + ((MattedPhoto)photo).Price.ToString("C");
                    labelOrderDescription.Text = ((MattedPhoto)photo).ToString();
                    break;

                case "Framed":
                    labelCostQuote.Text = "Cost:  " + ((FramedPhoto)photo).Price.ToString("C");
                    labelOrderDescription.Text = ((FramedPhoto)photo).ToString();
                    break;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            exitProgram();
        }

        private void exitProgram()
        {
            if (MessageBox.Show("Do You Really Want To Exit The Program?",
                          "EXIT PROGRAM NOW?!?!",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}