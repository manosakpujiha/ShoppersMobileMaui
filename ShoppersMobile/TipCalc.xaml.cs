using System.Globalization;
namespace ShoppersMobile;

public partial class TipCalc : ContentPage
{
	decimal bill;
	int tip;
	int noPersons = 1;

	public TipCalc()
	{
		InitializeComponent();
	}

    private void txtBill_Completed(object sender, EventArgs e)
    {
		bill = decimal.Parse(txtBill.Text);
		CalculateTotal();
    }

    private void CalculateTotal()
    {
        var totalTip = bill * tip / 100;

        var tipByPerson = totalTip / noPersons;
        lblTip.Text = $"{tipByPerson.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";

        var subTotal = bill / noPersons;
        lblSubtotal.Text = $"{subTotal.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";

        var totalByPerson = (bill + totalTip) / noPersons;
        lblTotal.Text = $"{totalByPerson.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";
    }

	private void SlideTip_ValueChanged(object sender, ValueChangedEventArgs e)

	{
		tip = (int)sldTip.Value;
		lblTip.Text = $"Tip:  {tip}%";
		CalculateTotal();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if (sender is Button)
		{
			var btn = (Button)sender;
			var percentage = int.Parse(btn.Text.Replace("%", ""));
			sldTip.Value = percentage;
			
		}
    }

    private void btnMinus_Clicked(object sender, EventArgs e)
    {
		if(noPersons > 1)
		{
			noPersons--;
		}
		lblNoPersons.Text = noPersons.ToString();
		CalculateTotal();
    }

    private void btnPlus_Clicked(object sender, EventArgs e)
    {
        noPersons++;
        lblNoPersons.Text = noPersons.ToString();
		CalculateTotal();
    }
}