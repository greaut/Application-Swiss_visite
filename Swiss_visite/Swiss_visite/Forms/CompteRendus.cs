﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Swiss_visite.Forms {
    public partial class CompteRendus : Form {
        private ConnectDBGSB ConnectBD;
        public CompteRendus(ConnectDBGSB connectBD) {
            InitializeComponent();
            this.ConnectBD = connectBD;
            bsRapport.DataSource = ConnectBD.RAPPORT_VISITE;
        }

        private void CompteRendus_Load(object sender, EventArgs e)
        {

        }
    }
}
