﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class frmUserDetails : Form
    {
        private int _UserID;
        public frmUserDetails(int UserID)
        {
            this._UserID = UserID;
            InitializeComponent();
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            ctrlLoginUserInformation.LoadUserInfo(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}