﻿namespace GenerateBarcode;

public partial class MainPage : ContentPage
{

	public MainPage(MainPageViewModel mainPageViewModel)
	{
		InitializeComponent();
		BindingContext = mainPageViewModel;
	}

}

