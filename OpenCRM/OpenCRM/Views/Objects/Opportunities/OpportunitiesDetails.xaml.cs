﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenCRM.Models.Objects.Opportunities;

namespace OpenCRM.Views.Objects.Opportunities
{
    /// <summary>
    /// Interaction logic for OpportunitiesDetails.xaml
    /// </summary>
    public partial class OpportunitiesDetails : Page
    {
        OpportunitiesModel _opportunityModel;

        public OpportunitiesDetails()
        {
            InitializeComponent();
            _opportunityModel = new OpportunitiesModel();

            _opportunityModel.LoadOpportunityDetails(this);

            _opportunityModel.SaveViewDate();
        }

        private void btnCancelOpportunity_Click(object sender, RoutedEventArgs e)
        {
            if (OpportunitiesModel.IsSearching)
            {
                PageSwitcher.Switch("/Views/Objects/Opportunities/SearchOpportunities.xaml");
            }
            else
            {
                PageSwitcher.Switch("/Views/Objects/Opportunities/OpportunitiesView.xaml");
            }
        }

        private void btnEditOpportunity_Click(object sender, RoutedEventArgs e)
        {
            PageSwitcher.Switch("/Views/Objects/Opportunities/CreateEditOpportunity.xaml");
        }

        private void btnDeleteOpportunity_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
