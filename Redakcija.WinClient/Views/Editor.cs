using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Redakcija.WinClient.Models;
using Redakcija.WinClient.WebServices;
using Zeks.WinClientLibrary.Views;
using Clanak = Redakcija.WinClient.Models.Clanak;
using Publikacija = Redakcija.WinClient.WebServices.Publikacija;

namespace Redakcija.WinClient.Views
{
    public partial class Editor : ViewBase
    {

        private List<Models.Publikacija> m_Publikacije;

        private Clanak m_Clanak = new Clanak();

        public Editor()
        {
            InitializeComponent();
            m_Clanak.PropertyChanged += (s, e) =>
            {
                switch (e.PropertyName)
                {
                    case "PublikacijaID":
                        var pub = m_Publikacije.Single(x => x.ID == m_Clanak.PublikacijaID);
                        rubrikaBindingSource.DataSource = pub.Rubrike;
                        break;
                }
            };
            clanakBindingSource.DataSource = m_Clanak;
        }

        protected override void OnLoad(EventArgs e)
        {
            using (var svc = new TestServiceClient())
            {
                svc.VratiPublikacijeCompleted += (s, e1) =>
                {
                    m_Publikacije = e1.Result.Select(ObjectMapper.Map).ToList();
                    publikacijaBindingSource.DataSource = m_Publikacije;
                };
                svc.VratiPublikacijeAsync();
            }
        }
    }
}
