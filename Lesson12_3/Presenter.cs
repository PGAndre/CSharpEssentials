using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_3
{
    class Presenter
    {
        Model model;
        MainWindow mainWindow;
        public Presenter(MainWindow mainwindow)
        {
            mainWindow = mainwindow;
            model = new Model();
            mainWindow.Event1 += MainWindow_Event1;

        }

        private void MainWindow_Event1(object sender, EventArgs e)
        {
            mainWindow.Result.Text = this.model.Event1(mainWindow.X.Text, mainWindow.Y.Text).ToString();
        }
    }
}
