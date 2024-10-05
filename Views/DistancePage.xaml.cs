using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DistanceAndWeightConverter.Views;

public partial class DistancePage : ContentPage
{
    private double KeyValue = 0;
    
    private double dbl_m2f = 3.280839895;
    private double dbl_m2i = 39.37007874;
    private double dbl_m2mi = 0.00062137119;
    private double dbl_m2m = 1;
    private double dbl_m2nm = 0.0005399568034557;
    private double dbl_m2y = 1.093613298;
    private double dbl_m2k = 0.001;
    
    
    
    public DistancePage()
    {
        InitializeComponent();
        Title = "Distance Converter";

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
        txtFeet.Text = "";
        txtInches.Text = "";
        txtKilometers.Text = "";
        txtMeters.Text = "";
        txtMiles.Text = "";
        txtNautical.Text = "";
        txtYards.Text = "";

    }
    
    private void Convert_OnClicked(object sender, EventArgs e)
    {
        txtFeet.Text = (KeyValue * dbl_m2f).ToString("g9");
        txtInches.Text = (KeyValue * dbl_m2i).ToString("g9");
        txtKilometers.Text = (KeyValue * dbl_m2k).ToString("g9");
        txtMeters.Text = (KeyValue * dbl_m2m).ToString("g9");
        txtMiles.Text = (KeyValue * dbl_m2mi).ToString("g9");
        txtNautical.Text = (KeyValue * dbl_m2nm).ToString("g9");
        txtYards.Text = (KeyValue * dbl_m2y).ToString("g9");
    }

    private void TxtMeters_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2m conversion
        double dblNumber;
        var isvalid = Double.TryParse(txtMeters.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_m2m;
        }
        else
        {
            KeyValue = 0;
        }
        
    }

    private void TxtInches_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2i conversion
        double dblNumber;
        var isvalid = Double.TryParse(txtInches.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_m2i;
        }
        else
        {
            KeyValue = 0;
        }

    }

    private void TxtFeet_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2f conversion
        double dblNumber;
        var isvalid = Double.TryParse(txtFeet.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_m2f;
        }
        else
        {
            KeyValue = 0;
        }

    }

    private void TxtYards_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2y conversion
        double dblNumber;
        var isvalid = Double.TryParse(txtYards.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_m2y;
        }
        else
        {
            KeyValue = 0;
        }

    }

    private void TxtMiles_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2mi conversion
        double dblNumber;
        var isvalid = Double.TryParse(txtMiles.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_m2mi;
        }
        else
        {
            KeyValue = 0;
        }

    }

    private void TxtNautical_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2nm conversion
        double dblNumber;
        var isvalid = Double.TryParse(txtNautical.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_m2nm;
        }
        else
        {
            KeyValue = 0;
        }

    }

    private void TxtKilometers_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2k conversion
        double dblNumber;
        var isvalid = Double.TryParse(txtKilometers.Text, out dblNumber);

        if (isvalid && dblNumber != 0)
        {
            KeyValue = dblNumber / dbl_m2k;
        }
        else
        {
            KeyValue = 0;
        }

    }

   
}