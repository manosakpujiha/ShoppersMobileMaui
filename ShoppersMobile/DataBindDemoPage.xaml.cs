using ShoppersMobile.Models;

namespace ShoppersMobile;

public partial class DataBindDemoPage : ContentPage
{
	public DataBindDemoPage()
	{
		InitializeComponent();
        var person = new Person
        {
            Name = "Zino Akpujiha",
            Phone = "419",
            Address = "Abuja"
        };
        BindingContext = person;
    }


    //private void btnChangeText_Clicked(object sender, EventArgs e)
    //{
    //    var person = new Person
    //    {
    //        Name = "John Doe",
    //        Phone = "555-555-5555",
    //        Address = "123 Main St"
    //    };
    //    Binding personBinding = new Binding();
    //    personBinding.Source = person;
    //    personBinding.Path = "Name";
    //    txtName.SetBinding(Label.TextProperty, personBinding);
    //}

    private void btnChangeText2_Clicked(object sender, EventArgs e)
    {
        var person = new Person
        {
            Name = "Manos Akpujiha",
            Phone = "7056186139",
            Address = "Sudbury"
        };
        BindingContext = person;
        //txtName3.BindingContext = person;
        //txtName3.SetBinding(Label.TextProperty, "Name");
    }
}