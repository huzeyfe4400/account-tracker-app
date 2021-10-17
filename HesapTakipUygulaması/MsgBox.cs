// <copyright file="MsgBox.cs" company="TutorialGenius.com and GinkoSolutions.com">
// Copyright (c) 2010 All Right Reserved
// </copyright>
// <author>Sean Ginko</author>
// <email>admin@ginkosolutions.com</email>
// <date>23-11-2010</date>
// <summary>MsgBox - An enhanced solution to the in-built MessageBox class. It's designed so that the styles, features and behaviour mimic the in-built control with added features.</summary>
namespace GinkoSolutions
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class MsgBox : Form
    {
        // Enhanced return object
        private static DialogResultNew result = null;

        // Private Constructor
        private MsgBox(IWin32Window owner, string text = "", string caption = "", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None, bool displayDoNotDisplayMessageAgain = true, Font messageFont = null, Color? messageForeColor = null)
        {
            InitializeComponent();

            // Setup return value and defaults each time as it's static - Cancel is default incase user x's the form
            result = new DialogResultNew { Result = System.Windows.Forms.DialogResult.Cancel, DoNotDisplayMessageAgain = false };

            // Set window size defaults
            this.SetWindowDefaults();
            
            // Set window title
            this.Text = caption;

            // Set the message text and styles
            txtText.Font = (messageFont == null) ? SystemFonts.DialogFont : messageFont;
            txtText.ForeColor = (!messageForeColor.HasValue) ? SystemColors.WindowText : messageForeColor.Value;
            txtText.Text = text; // Set text last as it depends on the font size etc

            // Toggle Display again checkbox

            // Set Icons [32x32]
            this.SetIcons(icon);

            // Set buttons and adjust form width based on button count
            this.SetButtons(buttons);
        }

        private void SetWindowDefaults()
        {
            // Make the maximum size of the form the same height as the screen
            this.MaximumSize = new Size(this.MaximumSize.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height); // Use primary display
            txtText.MaximumSize = new Size(txtText.MaximumSize.Width, this.MaximumSize.Height - 300);
        }

        private void SetIcons(MessageBoxIcon icon)
        {
            // Set icon based on requested icon
            if (icon == MessageBoxIcon.Asterisk) { picIcon.Image = SystemIcons.Asterisk.ToBitmap(); this.Icon = SystemIcons.Asterisk; }
            else if (icon == MessageBoxIcon.Error) { picIcon.Image = SystemIcons.Error.ToBitmap(); this.Icon = SystemIcons.Error; }
            else if (icon == MessageBoxIcon.Exclamation) { picIcon.Image = SystemIcons.Exclamation.ToBitmap(); this.Icon = SystemIcons.Exclamation; }
            else if (icon == MessageBoxIcon.Hand) { picIcon.Image = SystemIcons.Hand.ToBitmap(); this.Icon = SystemIcons.Hand; }
            else if (icon == MessageBoxIcon.Information) { picIcon.Image = SystemIcons.Information.ToBitmap(); this.Icon = SystemIcons.Information; }
            else if (icon == MessageBoxIcon.Question) { picIcon.Image = SystemIcons.Question.ToBitmap(); this.Icon = SystemIcons.Question; }
            else if (icon == MessageBoxIcon.Stop) { picIcon.Image = SystemIcons.Error.ToBitmap(); this.Icon = SystemIcons.Error; }
            else if (icon == MessageBoxIcon.Warning) { picIcon.Image = SystemIcons.Warning.ToBitmap(); this.Icon = SystemIcons.Warning; }
            else pnlIcon.Hide(); // Hide the whole icon panel so the text moves left with the docking if no icon
        }

        private void SetButtons(MessageBoxButtons buttons)
        {
            // Configure default form width for 3 buttons only. 2 buttons fit fine on the form at it's smallest size
            if ((buttons == MessageBoxButtons.AbortRetryIgnore || buttons == MessageBoxButtons.YesNoCancel) && this.Width < 349) this.Width = 349;

            // Configure button defaults
            Point firstButtonLocation = new Point(this.Width - 114, 13); // First button location based on form width. Buttons start from right, 10px apart.
            Size buttonSize = new Size(86, 24);

            // Init buttons
            List<Button> btnButtons = new List<Button>();
            for (int x = 0; x < 3; x++)
            {
                Button btnButton = new Button();
                btnButton.Size = buttonSize;
                btnButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                btnButton.Location = firstButtonLocation;
                firstButtonLocation.X = firstButtonLocation.X - (10 + buttonSize.Width); // Buttons start from right, 10px apart.
                btnButton.Click += btnButton_Click;
                btnButton.TabIndex = x;
                btnButton.Visible = false;
                pnlButtons.Controls.Add(btnButton);
                btnButtons.Add(btnButton);
            }

            // Configure buttons
            if (buttons == MessageBoxButtons.OK)
            {
                btnButtons[0].Text = "OK"; btnButtons[0].Visible = true;
            }
            else if (buttons == MessageBoxButtons.OKCancel)
            {
                btnButtons[0].Text = "Cancel"; btnButtons[0].Visible = true;
                btnButtons[1].Text = "OK"; btnButtons[1].Visible = true;
            }
            else if (buttons == MessageBoxButtons.YesNo)
            {
                btnButtons[0].Text = "No"; btnButtons[0].Visible = true;
                btnButtons[1].Text = "Yes"; btnButtons[1].Visible = true;
            }
            else if (buttons == MessageBoxButtons.RetryCancel)
            {
                btnButtons[0].Text = "Cancel"; btnButtons[0].Visible = true;
                btnButtons[1].Text = "Retry"; btnButtons[1].Visible = true;
            }
            else if (buttons == MessageBoxButtons.AbortRetryIgnore)
            {
                btnButtons[0].Text = "Ignore"; btnButtons[0].Visible = true;
                btnButtons[1].Text = "Retry"; btnButtons[1].Visible = true;
                btnButtons[2].Text = "Abort"; btnButtons[2].Visible = true;
            }
            else if (buttons == MessageBoxButtons.YesNoCancel)
            {
                btnButtons[0].Text = "Cancel"; btnButtons[0].Visible = true;
                btnButtons[1].Text = "No"; btnButtons[1].Visible = true;
                btnButtons[2].Text = "Yes"; btnButtons[2].Visible = true;
            }
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            // Perform actions depending on button pressed
            Button btn = sender as Button;
            if (btn.Text == "OK") result.Result = System.Windows.Forms.DialogResult.OK;
            if (btn.Text == "Yes") result.Result = System.Windows.Forms.DialogResult.Yes;
            if (btn.Text == "No") result.Result = System.Windows.Forms.DialogResult.No;
            if (btn.Text == "Cancel") result.Result = System.Windows.Forms.DialogResult.Cancel;
            if (btn.Text == "Retry") result.Result = System.Windows.Forms.DialogResult.Retry;
            if (btn.Text == "Abort") result.Result = System.Windows.Forms.DialogResult.Abort;
            if (btn.Text == "Ignore") result.Result = System.Windows.Forms.DialogResult.Ignore;

            // Store extra settings
            this.Close();
        }

        #region Show() OVERLOADS
        public static DialogResultNew Show(IWin32Window owner, string text)
        {
            MsgBox msgBox = new MsgBox(owner, text); // Call private constructor
            msgBox.ShowDialog(owner); // Code halts here until form is closed.
            return result; // Return dialog result with extra info
        }
        public static DialogResultNew Show(IWin32Window owner, string text, string caption)
        {
            MsgBox msgBox = new MsgBox(owner, text, caption);
            msgBox.ShowDialog(owner);
            return result;
        }
        public static DialogResultNew Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
        {
            MsgBox msgBox = new MsgBox(owner, text, caption, buttons);
            msgBox.ShowDialog(owner);
            return result;
        }
        public static DialogResultNew Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MsgBox msgBox = new MsgBox(owner, text, caption, buttons, icon);
            msgBox.ShowDialog(owner);
            return result;
        }
        public static DialogResultNew Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, bool displayDoNotDisplayMessageAgain = true)
        {
            MsgBox msgBox = new MsgBox(owner, text, caption, buttons, icon, displayDoNotDisplayMessageAgain);
            msgBox.ShowDialog(owner);
            return result;
        }
        public static DialogResultNew Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, bool displayDoNotDisplayMessageAgain = true, Font messageFont = null)
        {
            MsgBox msgBox = new MsgBox(owner, text, caption, buttons, icon, displayDoNotDisplayMessageAgain, messageFont);
            msgBox.ShowDialog(owner);
            return result;
        }
        public static DialogResultNew Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, bool displayDoNotDisplayMessageAgain = true, Font messageFont = null, Color? messageForeColor = null)
        {
            MsgBox msgBox = new MsgBox(owner, text, caption, buttons, icon, displayDoNotDisplayMessageAgain, messageFont, messageForeColor);
            msgBox.ShowDialog(owner);
            return result;
        }
        #endregion

        // Configure form size ad message size which depends on the incoming message size
        private void txtText_TextChanged(object sender, EventArgs e)
        {
            // Set correct width for textbox and form. Base this off incoming message length.
            const int paddingWidth = 0; // Optional: Amount of padding height to add
            int borderTotalWidth = txtText.Width - this.txtText.ClientSize.Width; // Get border horizontal thickness
            int textToFormWidthDifference = this.MaximumSize.Width - txtText.MaximumSize.Width; // Get width difference between the text message and the form
            Size textSize = TextRenderer.MeasureText(txtText.Text, txtText.Font);
            txtText.Width = textSize.Width + paddingWidth + borderTotalWidth; // As long as we have set MinimumSize and MaximumSize widths for txtText and the form, then we don't need to worry about safe guards
            this.Width = txtText.Width + textToFormWidthDifference; // Set new form width

            // Set correct height for textbox and form. Base this off incoming message length.
            const int paddingHeight = 0; // Optional: Amount of padding height to add
            int borderTotalHeight = txtText.Height - this.txtText.ClientSize.Height; // Get border vertical thickness
            int textToFormHeightDifference = this.MinimumSize.Height - txtText.MinimumSize.Height; // Get height difference between the text message and the form
            int numLines = txtText.GetLineFromCharIndex(txtText.TextLength) + 1; // Get number of lines (first line is 0)
            txtText.Height = txtText.Font.Height * numLines + paddingHeight + borderTotalHeight ; // Set height (height of one line * number of lines + spacing)
            this.Height = txtText.Height + textToFormHeightDifference; // Set new form height

            // If text field has reached it's maximum height, add scrollbars
            if (txtText.Height == txtText.MaximumSize.Height) txtText.ScrollBars = ScrollBars.Vertical;
        }
    }

    /// <summary>
    /// For handling the enhanced return value
    /// </summary>
    public class DialogResultNew
    {
        public DialogResult Result { get; set; }
        public bool DoNotDisplayMessageAgain { get; set; }
    }
}
