using System;
using mediator.models;

namespace mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new Mediator();
            var btn = new Button(mediator);
            var txt = new TextBox(mediator);
            var cb = new CheckBox(mediator);

            mediator.button = btn;
            mediator.checkBox = cb;
            mediator.textBox = txt;

            btn.Click();
            txt.Click();
            btn.KeyPress();
            txt.Text = "asdasdsadas";
            txt.KeyPress();
            cb.Click();
            btn.Click();
        }
    }
}
