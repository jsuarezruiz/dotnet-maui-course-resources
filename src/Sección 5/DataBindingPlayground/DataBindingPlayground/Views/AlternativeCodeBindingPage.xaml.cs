﻿namespace DataBindingPlayground
{
    public partial class AlternativeCodeBindingPage : ContentPage
    {
        public AlternativeCodeBindingPage()
        {
            InitializeComponent();

            label.SetBinding(Label.ScaleProperty, new Binding("Value", source: slider));
        }
    }
}