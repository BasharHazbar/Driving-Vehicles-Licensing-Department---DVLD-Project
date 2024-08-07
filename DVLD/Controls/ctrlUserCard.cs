﻿using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        public ctrlUserCard()
        {
            InitializeComponent();
        }


        public void LoadUserData(clsUsers User)
        {
            if (User != null)
            {
                lbUserIDValue.Text = User.UserID.ToString();

                lbUserNameValue.Text = User.UserName;

                lbIsAtiveValue.Text = User.IsActive ? "Yes" : "No";
            }
        }

    }
}
