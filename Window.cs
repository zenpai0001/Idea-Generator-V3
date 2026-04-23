using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using Terminal.Gui;
using Terminal.Gui.App;
using Terminal.Gui.Configuration;
using Terminal.Gui.Drawing;
using Terminal.Gui.Drivers;
using Terminal.Gui.Input;
using Terminal.Gui.Testing;
using Terminal.Gui.Time;
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

        
        //This can be overloaded later on.
        public MainWindow()
        {
            //Draw the GUI elements here

            Console.Title = "Idea Generator";

            drawWindow = new Terminal.Gui.Views.Window
            {
                Title = "Window",
                Arrangement = ViewArrangement.Fixed,
                BorderStyle = LineStyle.Rounded,
                Width = Dim.Fill(),
                Height = Dim.Fill()
            };

            var button = new Button
            {
                Text = "Button",
                Width = Dim.Auto(),
                Height = Dim.Auto(),
                BorderStyle = LineStyle.Rounded
            };


            var label = new Label()
            {
                Text = "Label",
                Width = Dim.Auto(),
                Height = Dim.Auto(),
                BorderStyle = LineStyle.Rounded
            };

            var bar = new Bar()
            {
                AssignHotKeys = true,
                BorderStyle = LineStyle.Rounded,
                Width = Dim.Auto()
            };

            bar.AddShortcutAt(0, new MenuItem());

            drawWindow.Add(label);
            

            label.Add(bar);

            Add(drawWindow);
        }
    }
}
