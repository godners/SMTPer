using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace SMTPer
{
    internal partial class WinMain : Form
    {
        MailPriority TodoPriority = MailPriority.Normal;
        internal WinMain() => InitializeComponent();
        private void CheckBoxAuthentication_CheckedChanged(object sender, EventArgs e)
        { TextBoxUsnm.Enabled = CheckBoxAuthentication.Enabled; TextBoxPswd.Enabled = CheckBoxAuthentication.Enabled; }
        private void CheckBoxFrom_CheckedChanged(object sender, EventArgs e)
        { TextBoxFrom.Enabled = CheckBoxFrom.Checked; TextBoxDisplay.Enabled = CheckBoxFrom.Checked; }
        private void CheckBoxTo_CheckedChanged(object sender, EventArgs e) => TextBoxTo.Enabled = CheckBoxTo.Checked;
        private void CheckBoxCC_CheckedChanged(object sender, EventArgs e) => TextBoxCC.Enabled = CheckBoxCC.Checked;
        private void CheckBoxBCC_CheckedChanged(object sender, EventArgs e) => TextBoxBC.Enabled = CheckBoxBC.Checked;
        private void CheckBoxSubject_CheckedChanged(object sender, EventArgs e) => TextBoxSubject.Enabled = CheckBoxSubject.Checked;
        private void CheckBoxBody_CheckedChanged(object sender, EventArgs e) => TextBoxBody.Enabled = CheckBoxBody.Checked;
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            String TimeStamp = $"[{DateTime.Now:HH:mm:ss.fff}]"; String SuccResult = $"{TimeStamp} 250 OK.";
            String RecvResult = $"{TimeStamp} No Receiver."; String EmptyResult = $"{TimeStamp} Argument From And Username Can NOT All Empty";
            MailMessage MailTodo = new MailMessage(); MailAddress AddressFrom;
            try
            {
                String StrAddress = (CheckBoxFrom.Checked ? TextBoxFrom.Text : TextBoxUsnm.Text).Trim();
                String StrDisplay = TextBoxDisplay.Text.Trim() == String.Empty ? StrAddress : TextBoxDisplay.Text.Trim();
                AddressFrom = new MailAddress(StrAddress, StrDisplay, Encoding.UTF8);
            }
            catch (FormatException ex) { PushResult($"{TimeStamp} {ex.Message}"); return; }
            catch (ArgumentException) { PushResult(EmptyResult); return; }
            MailTodo.From = AddressFrom; MailTodo.Sender = AddressFrom; MailTodo.Priority = TodoPriority;
            String[] TextTo = TextBoxTo.Text.Split(';'), TextCC = TextBoxCC.Text.Split(';'), TextBC = TextBoxBC.Text.Split(';');
            if (TextTo.Length + TextCC.Length + TextBC.Length == 0) { PushResult(RecvResult); return; }
            try
            {
                if (CheckBoxTo.Checked) foreach (String Address in TextTo) MailTodo.To.Add(Address.Trim());
                if (CheckBoxCC.Checked) foreach (String Address in TextCC) MailTodo.CC.Add(Address.Trim());
                if (CheckBoxBC.Checked) foreach (String Address in TextBC) MailTodo.Bcc.Add(Address.Trim());
            }
            catch (FormatException ex) { PushResult($"{TimeStamp} {ex.Message}"); return; }
            if (CheckBoxSubject.Checked) { MailTodo.Subject = TextBoxSubject.Text; MailTodo.SubjectEncoding = Encoding.UTF8; }
            if (CheckBoxBody.Checked) { MailTodo.Body = TextBoxBody.Text; MailTodo.BodyEncoding = Encoding.UTF8; MailTodo.IsBodyHtml = false; }

            SmtpClient Client = new SmtpClient() { Host = TextBoxServer.Text.Trim(), Timeout = 5000, DeliveryMethod = SmtpDeliveryMethod.Network };
            if (CheckBoxAuthentication.Checked) Client.Credentials = new NetworkCredential(TextBoxUsnm.Text.Trim(), TextBoxPswd.Text.Trim());
            try { Client.Send(MailTodo); PushResult(SuccResult); }
            catch (SmtpException ex) { PushResult($"{TimeStamp} [{(Int32)ex.StatusCode}] {ex.StatusCode}.\r\n{ex.Message}"); }
        }
        private void LabelResult_Show(object sender, EventArgs e) => MessageBox.Show(LabelResult.Text, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void RadioPriority_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioLow.Checked) TodoPriority = MailPriority.Low;
            if (RadioNormal.Checked) TodoPriority = MailPriority.Normal;
            if (RadioHigh.Checked) TodoPriority = MailPriority.High;
        }
        private void PushResult(String Message) { LabelResult.Text = Message; ToolTipMain.SetToolTip(LabelResult, Message); }
    }
}
