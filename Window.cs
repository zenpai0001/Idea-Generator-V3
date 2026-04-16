using System;
using System.Collections.Generic;
using System.Text;
using Terminal.Gui;
using Terminal.Gui.App;
using Terminal.Gui.Configuration;
using Terminal.Gui.Drawing;
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
    public void Button()
    {
        var button = new Button();
    }
    public void Label()
    {
        var label = new Label();
    }
        
    }
}
