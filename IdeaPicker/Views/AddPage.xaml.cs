using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdeaPicker.Models;

namespace IdeaPicker.Views;

public partial class AddPage : ContentPage
{
    public AddPage()
    {
        InitializeComponent();
        Title = "Add New Idea";
    }

    private void Add_OnClicked(object sender, EventArgs e)
    {
        var newIdea = new Idea();

        newIdea.Title = txtTitle.Text;
        
        App.IdeaList.Add(newIdea);

        txtTitle.Text = "";
    }
}