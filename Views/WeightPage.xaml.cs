using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceAndWeightConverter.Views;

public partial class WeightPage : ContentPage
{
    private double KeyValue = 0;
    
    private double dbl_p2o = 16;
    private double dbl_p2g = 453.592;
    private double dbl_p2k = 0.453592;
    private double dbl_p2p = 1;
    
    public WeightPage()
    {
        InitializeComponent();
        Title = "Weight Converter";

        ToolbarItem tbi = new ToolbarItem(); //create tbi ToolbarItem
        tbi.Text = "About"; //setting tbi object the text About
        this.ToolbarItems.Add(tbi); //add to existing toolbar

        tbi.Clicked += delegate // creating a click event. delegate is a helper saying hey do this
        {
            Navigation.PushAsync(new AboutPage()); //creating link to About page
        };
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtPounds.Text = "";
        txtGrams.Text = "";
        txtOunces.Text = "";
        txtKilograms.Text = "";
    }

    private void Convert_OnClicked(object sender, EventArgs e)
    {
        txtPounds.Text = (KeyValue * dbl_p2p).ToString("g9");
        txtOunces.Text = (KeyValue * dbl_p2o).ToString("g9");
        txtGrams.Text = (KeyValue * dbl_p2g).ToString("g9");
        txtKilograms.Text = (KeyValue * dbl_p2k).ToString("g9");
    }

    private void TxtPounds_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //p2p conversion
        double dblNumber;
        var isvalid = Double.TryParse(txtPounds.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_p2p;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtOunces_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //p2o conversion
        double dblNumber;
        var isvalid = Double.TryParse(txtOunces.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_p2o;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtGrams_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //p2g conversion
        double dblNumber;
        var isvalid = Double.TryParse(txtGrams.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_p2g;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtKilograms_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2m conversion
        double dblNumber;
        var isvalid = Double.TryParse(txtKilograms.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_p2k;
        }
        else
        {
            KeyValue = 0;
        }
    }
}