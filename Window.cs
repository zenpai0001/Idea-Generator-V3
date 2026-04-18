using System;
using System.Collections.Generic;
using System.Text;
using Terminal.Gui;
using Terminal.Gui.App;
using Terminal.Gui.Configuration;
using Terminal.Gui.Drawing;

using Terminal.Gui.ViewBase;

using Terminal.Gui.Views;

namespace Idea_Generator_V3
{
    public class Window 
    {
        public void Init()
        {
            using(IApplication app = Application.Create().Init())
            {
                ConfigurationManager.RuntimeConfig = """{ "Theme": "Amber Phosphor" }""";
                ConfigurationManager.Enable(ConfigLocations.All);

                

                app.Run<MainWindow>().GetResult<string>();

            }
        }
    }
    public sealed class MainWindow : Runnable<string>
    {

        //This is a bit complicated to be honest but it is neccessary.
        public Terminal.Gui.Views.Window? drawWindow;

        public Terminal.Gui.FileServices.IFileOperations? fileOperations;

        //Adding component fields for reusability.
        public View GetView;

        public Label GetLabel;

        public Button button;

        
        //This can be overloaded later on.
        public MainWindow()
        {
            Console.Title = "Idea Generator";

            drawWindow = new Terminal.Gui.Views.Window
            {
                Title = "Window",
                Arrangement = ViewArrangement.Fixed,
                Width = Dim.Auto()
            };

            button = new Button
            {
                Text = "Button",
                X = 5,
                Y = 10,
                Width = Dim.Fill()
            };
            button = new Button
            {
                Text = "Text",
                X= button.X + 5,
                Y = button.Y + 0,
                Width = Dim.Fill()
            };

            

            
            Add(drawWindow,button);

            GetView?.ScrollVertical(10);
        }
        
    }
}
