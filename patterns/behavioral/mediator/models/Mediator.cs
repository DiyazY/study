using System;

namespace mediator.models
{
    public interface IMediator
    {
        void Notify(Component sender,string senderEvent);
    }

    public class Mediator : IMediator
    {
        private bool isCheked{get;set;}
        public Button button {get;set;}
        public CheckBox checkBox {get;set;}
        public TextBox textBox {get;set;}
        public void Notify(Component sender,string senderEvent)
        {
            System.Console.WriteLine($"{sender.Title}-{senderEvent}");
            if(sender == button && isCheked){
                System.Console.WriteLine($"---clicked(you can call some action here!!!)");
            }
            if(sender == checkBox){
                isCheked = !isCheked;
                System.Console.WriteLine($"---isChecked:{isCheked}");
            }
            if(sender == textBox){
                System.Console.WriteLine($"---{textBox.Text}");
            }
        }
    }

    //Absract class
    public abstract class Component{
        protected readonly IMediator _mediator;
        public Component(IMediator mediator){
            _mediator = mediator;
        }
        public string Title{get;set;}

        public virtual void Click(){
            _mediator.Notify(this,"click");
        }
        public void KeyPress(){
            _mediator.Notify(this,"keypress");
        }
    }

    public class Button : Component
    {
        public Button(IMediator mediator) : base(mediator)
        {
            Title = "button";
        }
    }
    public class TextBox : Component
    {
        public string Text{get;set;}
        public TextBox(IMediator mediator) : base(mediator)
        {
            Title = "textbox";
        }
    }
    public class CheckBox : Component
    {
        public CheckBox(IMediator mediator) : base(mediator)
        {
            Title = "checkbox";
        }

        public override void Click(){
            _mediator.Notify(this,"check");
        }
    }
}
