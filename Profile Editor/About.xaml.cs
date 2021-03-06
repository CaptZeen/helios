﻿//  Copyright 2014 Craig Courtney
//    
//  Helios is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  Helios is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace GadrocsWorkshop.Helios.ProfileEditor
{
    using System;
    using System.Reflection;
    using System.Windows;
    using System.Windows.Input;

    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();
        }

        protected override void OnActivated(EventArgs e)
        {
            VersionBlock.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();
            ContributionBlock.Text = ContributionBlock.Text + " Cylution CaptZeen yzfanimal damien022";
            StatusBlock.Text = "Released";
            base.OnActivated(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            Close();
            base.OnKeyDown(e);
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            Close();
            base.OnMouseDown(e);
        }
    }
}
