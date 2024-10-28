using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;


namespace scripts
{
     public class toast
    {
        public void teste(List<string> text)
        {
            ToastNotificationManagerCompat.History.Clear();
            if (text.Count > 0)
            {
                for (int i = 0; i < text.Count; i++)
                {
                    ToastContentBuilder toast = new ToastContentBuilder();
                    //toast.AddArgument("x1");
                    toast.AddText(text[i]);               
                    toast.AddHeader("t1", "Atualização do dicionário de dados",new ToastArguments());
                    toast.SetProtocolActivation(new Uri("about: blank"));
                    toast.SetToastScenario(ToastScenario.Reminder);
                    toast.SetToastDuration(ToastDuration.Short);
                    toast.Show();
                }
            }
        }
    }
}
