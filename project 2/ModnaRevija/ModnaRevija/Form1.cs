using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModnaRevija.Enitites;
using System.Data.SqlClient;
using NHibernate.Type;
using NHibernate.Proxy;

namespace ModnaRevija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Mapiranje entiteta
        #region Ucesnik
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaRevija.Enitites.Ucesnik u = s.Load<ModnaRevija.Enitites.Ucesnik>(1604);

                MessageBox.Show(u.Ime + u.Prezime);

                s.Close();

            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodavanjeUcesnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ucesnik u = new Ucesnik();
                u.MatBr = 1604;
                u.Ime = "Momcilo";
                u.Prezime = "Mitic";
                u.Pol = "M";
                u.DatumRodjenja = new DateTime(1996, 4, 16);

                s.Save(u);

                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnBrisanjeUcesnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ucesnik u = s.Load<Ucesnik>(1604);

                s.Delete(u);
                s.Flush();
                s.Close();
            }
            catch(Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
        #endregion

        #region ModnaAgencija
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaAgencija modnaAgencija = s.Load<ModnaAgencija>(100);

                s.Delete(modnaAgencija);

                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUcitavanjeMAgencije_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaRevija.Enitites.ModnaAgencija modnaAgencija = s.Load<ModnaRevija.Enitites.ModnaAgencija>(100);

                MessageBox.Show(modnaAgencija.NazivAgencije + " " + modnaAgencija.Pib);

                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodavanjeModneAgencije_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaAgencija modnaAgencija = new ModnaAgencija();

                modnaAgencija.NazivAgencije = "Loreal";
                modnaAgencija.Pib = 100;
                modnaAgencija.Sediste = "Pariz";
                modnaAgencija.DatumOsnivanja = new DateTime(1986, 10, 1);

                s.Save(modnaAgencija);
                s.Flush();

                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Casopisi
        private void btnLoadCasopis_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaRevija.Enitites.Casopisi casopisi = s.Load<Casopisi>(123);
                MessageBox.Show(casopisi.Id + " " + casopisi.Naziv + "Maneken na naslovnoj strani: " + casopisi.Maneken.Ime);

                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajCasopis_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Casopisi casopisi = new Casopisi()
                {
                    Naziv = "Politikin zabavnik"
                };

                Maneken maneken = s.Load<Maneken>(305);

                casopisi.Maneken = maneken;
                maneken.Casopisi.Add(casopisi);
                //casopisi.MatbrManeken = 1604;
                //casopisi.Naziv = "Vogue";



                s.Save(casopisi);
                s.Flush();
                s.Close();
                MessageBox.Show($"Dodat je casopis {casopisi.Naziv}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteCasopis_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Casopisi casopis = s.Load<Casopisi>(123);

                s.Delete(casopis);
                s.Flush();

                s.Close();
                MessageBox.Show("Casopis je obrisan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Maneken
        private void btnLoadManeken_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaRevija.Enitites.Maneken maneken = s.Load<ModnaRevija.Enitites.Maneken>(1604);
                //MessageBox.Show(maneken.Matbr.ToString());
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddManeken_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();



                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteManeken_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Maneken maneken = s.Load<Maneken>(1604);
                s.Delete(maneken);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ModniKreator
        private void btnAddModniKreator_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModniKreator u = new ModniKreator();
                //u.Matbr = 1604;
                u.Zemlja = "Avganistan";

                s.Save(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadModniKreator_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModniKreator u = s.Load<ModniKreator>(1604);
               // MessageBox.Show(u.Matbr + " " + u.Zemlja);
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void brnDeleteModniKreator_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModniKreator u = s.Load<ModniKreator>(1604);

                s.Delete(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ModnaRevija
        private void btnLoadModnaRevija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaRevija.Enitites.ModnaRevija u = s.Load<ModnaRevija.Enitites.ModnaRevija>(1);
                MessageBox.Show(u.Id + " " + u.Naziv);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddModnaRevija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaRevija.Enitites.ModnaRevija u = new Enitites.ModnaRevija();

                u.Rbr = 1;
                u.Naziv = "BestOfTheBest";
                u.Mesto = "Tor";
                u.DatumVremeOdrzavanja = new DateTime(2020, 10, 12, 22, 13, 15);

                s.Save(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteModnaRevija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaRevija.Enitites.ModnaRevija u = s.Load<ModnaRevija.Enitites.ModnaRevija>(2);

                s.Delete(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Internacionalna
        private void btnLoadInternacionlna_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Internacionalna u = s.Load<Internacionalna>(2007);

                MessageBox.Show($"Naziv agencije: {u.NazivAgencije} Datum osnivanja agencije: {u.DatumOsnivanja}");

                foreach(Zemlje z in u.Zemlje)
                {
                    MessageBox.Show($"Drzava u kojoj agencija ima sediste: {z.Naziv}");
                }

                // MessageBox.Show(u.PibAgencija.ToString());

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddInternacionalna_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Internacionalna u = new Internacionalna();

                //u.PibAgencija = 100;

                s.Save(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelInternacionalna_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Internacionalna u = s.Load<Internacionalna>(2007);

                s.Delete(u);
                s.Flush();
                s.Close();
                MessageBox.Show("Internacionalna agencija je obrisana");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Kuce
        private void btnLoadKuce_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kuce u = s.Load<Kuce>(48);

                MessageBox.Show(u.Naziv);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddKuce_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kuce u = new Kuce()
                {
                    Naziv = "Supreme"
                };

                ModniKreator m = s.Load<ModniKreator>(102);

                u.ModniKreator = m;
                m.Kuce.Add(u);

                //u.ModniKreator = m;
                ////u.MatbrKreator = 100;
                //u.Naziv = "Prada";


                s.Save(u);
                s.Flush();
                s.Close();

                MessageBox.Show("Modna kuca je dodata");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelKuce_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kuce u = s.Load<Kuce>(48);

                s.Delete(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Nastupa
        private void btnLoadNastupa_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nastupa u = s.Load<Nastupa>(2);
                MessageBox.Show(u.MatbrManeken.ToString());

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddNastupa_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nastupa u = new Nastupa();

                u.IdRevija = 2;
                u.MatbrManeken = 1604;

                s.Save(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelNastupa_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nastupa u = s.Load<Nastupa>(1);

                s.Delete(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Predstavlja
        private void btnLoadPredstavlja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavlja u = s.Load<Predstavlja>(2);
                MessageBox.Show(u.Id.ToString());
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddPredstavlja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavlja u = new Predstavlja();

                //u.IdRevija = 2;
                //u.MatbrKreator = 1604;
                u.Kolaborirali = "DA";

                s.Save(u);
                s.Flush();
                s.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelPredstavljali_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavlja u = s.Load<Predstavlja>(1);

                s.Delete(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Pripada
        private void btnLoadPripada_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pripada u = s.Load<Pripada>(2);
                MessageBox.Show(u.Id.ToString());
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddPripada_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pripada u = new Pripada();

                u.MatbrManeken = 1604;
                u.PibAgencija = 100;

                s.Save(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelPripada_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pripada u = s.Load<Pripada>(1);

                s.Delete(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Specijalni gost
        private void btnLoadSpecGost_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpecGost u = s.Load<SpecGost>(2);
                MessageBox.Show(u.ImeGosta);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddSpecGost_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaRevija.Enitites.ModnaRevija m = new Enitites.ModnaRevija()
                {
                    Mesto = "Los Angeles",
                    Rbr = 1,
                    Naziv = "Hello World",
                    DatumVremeOdrzavanja = new DateTime(2020, 10, 12)
                };

                SpecGost g = new SpecGost()
                {
                    ImeGosta = "Henry",
                    PrezimeGosta = "Danger",
                    Zanimanje = "Actor"
                };

                g.Gostuje = m;
                m.SpecijalniGosti.Add(g);

                s.Save(m);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelSpecGost_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpecGost u = s.Load<SpecGost>(34);

                s.Delete(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        #endregion

        #region Mapiranje veza
        private void btnManyToOneSGostMRevija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpecGost g = s.Load<SpecGost>(22);

                MessageBox.Show(g.ImeGosta + " " + g.Gostuje.Naziv);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOneToManyMRevijaToSGost_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaRevija.Enitites.ModnaRevija m = s.Load<ModnaRevija.Enitites.ModnaRevija>(21);

                MessageBox.Show($"Modna revija {m.Id} {m.Naziv}");

                //foreach(SpecGost g in m.SpecijalniGosti)
                //{
                //    MessageBox.Show($"{g.ImeGosta} {g.PrezimeGosta}");
                //}

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnLoadZemlja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zemlje z = s.Load<Zemlje>(11);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddZemlja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zemlje z = new Zemlje();


                //z.PibAgencija = 2002;
                z.Naziv = "Serbia";


                s.Save(z);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelZemlja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zemlje z = s.Load<Zemlje>(21);

                s.Delete(z);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnManyToOneZemljeToMAgencija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zemlje z = s.Load<Zemlje>(20);

                MessageBox.Show($"{z.InternacionalnaMAgencija.NazivAgencije}");

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOneToManyInterToZemlje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Internacionalna i = s.Load<Internacionalna>(2003);

                foreach(Zemlje z in i.Zemlje)
                {
                    MessageBox.Show(z.Naziv);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnManyToOneKuceToMKreator_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kuce k = s.Load<Kuce>(34);

                MessageBox.Show(k.ModniKreator.Ime + " " +k.ModniKreator.Prezime);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOneToManyMKreatorToKuce_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModniKreator m = s.Load<ModniKreator>(102);

                foreach(Kuce k in m.Kuce)
                {
                    MessageBox.Show(k.Naziv);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOneToManyManekenToCasopisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Maneken m = s.Load<Maneken>(300);

                foreach(Casopisi c in m.Casopisi)
                {
                    MessageBox.Show(c.Naziv);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnManyToOneCasopisiToManeken_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Casopisi c = s.Load<Casopisi>(78);

                MessageBox.Show($"{c.Maneken.Ime} {c.Maneken.Prezime}");

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnManyToManyManekenModnaRevija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Maneken m = s.Load<Maneken>(300);

                foreach(ModnaRevija.Enitites.ModnaRevija mr in m.ModneRevije)
                {
                    MessageBox.Show($"Modne revije na kojima je ucestvovao maneken {m.Ime}: {mr.Naziv}");
                }

                ModnaRevija.Enitites.ModnaRevija re = s.Load<ModnaRevija.Enitites.ModnaRevija>(23);

                foreach(Maneken mn in re.Manekeni)
                {
                    MessageBox.Show($"Manekeni na modnoj reviji {re.Naziv} {mn.Ime}");
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnManyToManyManekenModnaAgencija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Maneken m = s.Load<Maneken>(306);

                foreach(ModnaAgencija modnaAgencija in m.ModneAgencije)
                {
                    MessageBox.Show($"Naziv modne agencije u kojoj je maneken {m.Ime}: {modnaAgencija.NazivAgencije}");
                }

                ModnaAgencija ma = s.Load<ModnaAgencija>(2002);

                foreach(Maneken maneken in ma.Manekeni)
                {
                    MessageBox.Show($"Maneken u modnoj agenciij {ma.NazivAgencije}: {maneken.Ime} ");
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModniKreator mk = new ModniKreator();

                mk.Ime = "John";
                mk.Prezime = "Doe";
                mk.Pol = "M";
                mk.Zemlja = "Serbia";
                mk.MatBr = 1002;

                ModnaRevija.Enitites.ModnaRevija mr = new Enitites.ModnaRevija();

                mr.Rbr = 6;
                mr.Naziv = "Fashion show No 1";
                mr.Mesto = "London";
                mr.DatumVremeOdrzavanja = new DateTime(2020, 2, 2, 2, 2, 2);

                Predstavlja predstavlja = new Predstavlja();


                predstavlja.ModniKreator = mk;
                predstavlja.ModnaRevija = mr;
                predstavlja.Kolaborirali = "NE";
                mr.MKreatorNaMReviji.Add(predstavlja);
                mk.Revije.Add(predstavlja);

                s.Save(predstavlja);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddManekenManyToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaRevija.Enitites.ModnaRevija mr = new Enitites.ModnaRevija()
                {
                    Rbr = 2,
                    Naziv = "Steven Dockman AW20",
                    Mesto = "Serbia",
                    DatumVremeOdrzavanja = new DateTime(2020, 02, 13, 15, 00, 00)
                };

                Maneken maneken = s.Load<Maneken>(301);

                maneken.ModneRevije.Add(mr);
                mr.Manekeni.Add(maneken);

                s.Save(mr);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addManekenToMAgencijaManyToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaAgencija ma = new ModnaAgencija()
                {
                    Pib = 2005,
                    NazivAgencije = "Fashion Fit Models",
                    Sediste = "New York",
                    DatumOsnivanja = new DateTime(2007, 03, 25)
                };

                Maneken maneken = s.Load<Maneken>(308);

                maneken.ModneAgencije.Add(ma);
                ma.Manekeni.Add(maneken);

                s.Save(ma);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddManekenSpecijalizacija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Maneken m = new Maneken();

                m.MatBr = 315;
                m.Ime = "Crystal";
                m.Prezime = "Renn";
                m.Pol = "F";
                m.DatumRodjenja = new DateTime(1986, 6, 18);

                m.BojaOciju = "brown";
                m.BojaKose = "black";
                m.KonfBroj = 38;
                m.Visina = 180;
                m.Tezina = 60;

                Casopisi c1 = new Casopisi()
                {
                    Naziv = "Politikin zabavnik"
                };


                Casopisi c2 = new Casopisi()
                {
                    Naziv = "Blic zena"
                };

                c1.Maneken = m;
                c2.Maneken = m;

                m.Casopisi.Add(c1);
                m.Casopisi.Add(c2);

                s.Save(m);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddMKreatorSpecijalizacija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModniKreator mk = new ModniKreator();

                mk.MatBr = 206;
                mk.Ime = "Pierre";
                mk.Prezime = "Cardin";
                mk.Pol = "M";
                mk.DatumRodjenja = new DateTime(1922, 2, 7);

                mk.Zemlja = "Italy";

                s.Save(mk);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddInterModnaAgencija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Internacionalna i = new Internacionalna();

                i.Pib = 2007;
                i.NazivAgencije = "Hello World";
                i.Sediste = "London";
                i.DatumOsnivanja = new DateTime(2002, 10, 25);

                Zemlje z1 = new Zemlje();
                z1.Naziv = "France";

                Zemlje z2 = new Zemlje();
                z2.Naziv = "Germany";

                i.Zemlje.Add(z1);
                i.Zemlje.Add(z2);

                z1.InternacionalnaMAgencija = i;
                z2.InternacionalnaMAgencija = i;

                s.Save(i);
                s.Flush();
                s.Close();

                MessageBox.Show("Internacionalna modna agencija je dodata");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateCasopis_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Casopisi casopis = s.Load<Casopisi>(123);

                casopis.Naziv = "Bumerang";

                s.Save(casopis);
                s.Flush();
                s.Close();

                MessageBox.Show($"Nova naziv casopisa je: {casopis.Naziv}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateIntMAgencija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Internacionalna i = s.Load<Internacionalna>(2007);

                i.NazivAgencije = "New Age Fashion";

                s.Save(i);
                s.Flush();
                s.Close();
                MessageBox.Show($"Naziv agencije promenjen je u: {i.NazivAgencije}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateModnaKuca_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kuce k = s.Load<Kuce>(48);

                k.Naziv = "Steven Dockman";

                s.Save(k);
                s.Flush();
                s.Close();

                MessageBox.Show($"Naziv je promenjen u {k.Naziv}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateManeken_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Maneken m = s.Load<Maneken>(315);

                m.Ime = "Petar";
                m.Prezime = "Petrovic";

                s.Save(m);
                s.Flush();
                s.Close();

                MessageBox.Show($"Ime je promenjeno u {m.Ime}  Prezime je promenjeno u {m.Prezime}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelManeken_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Maneken m = s.Load<Maneken>(315);

                s.Delete(m);

                s.Flush();

                s.Close();

                MessageBox.Show("Maneken je obrisan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void brnLoadManeken_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Maneken m = s.Load<Maneken>(315);

                MessageBox.Show($"Ime manekena: {m.Ime}");

                foreach(Casopisi c in m.Casopisi)
                {

                    MessageBox.Show($"Casopis {c.Naziv}");
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOneToManyManToCas_Click(object sender, EventArgs e)
        {

        }

        private void btnAddModnaAgencija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaAgencija ma = new ModnaAgencija();

                ma.Pib = 2008;
                ma.NazivAgencije = "Fashion Prep Ltd.";
                ma.Sediste = "Belgrade";
                ma.DatumOsnivanja = new DateTime(1993, 5, 5);

                Maneken m = new Maneken();

                m.MatBr = 999;
                m.Ime = "Crystal";
                m.Prezime = "Renn";
                m.Pol = "F";
                m.DatumRodjenja = new DateTime(1986, 6, 18);

                m.BojaOciju = "brown";
                m.BojaKose = "black";
                m.KonfBroj = 38;
                m.Visina = 180;
                m.Tezina = 60;

                m.ModneAgencije.Add(ma);
                ma.Manekeni.Add(m);


                s.Save(ma);
                s.Flush();

                s.Close();
                MessageBox.Show($"Dodata je agencija: {ma.NazivAgencije}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateModnaAgencija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaAgencija ma = s.Load<ModnaAgencija>(2008);

                ma.NazivAgencije = "Tommorow Fashion";

                s.Save(ma);
                s.Flush();
                s.Close();

                MessageBox.Show($"Naziv agencije promenjen je u: {ma.NazivAgencije}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadModnaAgencija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaAgencija ma = s.Load<ModnaAgencija>(2008);

                MessageBox.Show($"Naziv modne agencije: {ma.NazivAgencije}");

                foreach(Maneken maneken in ma.Manekeni)
                {
                    MessageBox.Show($"Maneken u modnoj agenciji: {maneken.Ime}");
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteModnaAgencija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaAgencija ma = s.Load<ModnaAgencija>(2008);

                s.Delete(ma);
                s.Flush();

                s.Close();
                MessageBox.Show("Modna agencija je obrisana");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddModnaRevija_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaRevija.Enitites.ModnaRevija mr = new Enitites.ModnaRevija();

                mr.Rbr = 5;
                mr.Naziv = "Modna Revija veka";
                mr.Mesto = "London";
                mr.DatumVremeOdrzavanja = new DateTime(2020, 2, 2, 2, 2, 2);

                Maneken m = new Maneken();

                m.MatBr = 1000;
                m.Ime = "Crystal";
                m.Prezime = "Renn";
                m.Pol = "F";
                m.DatumRodjenja = new DateTime(1986, 6, 18);

                m.BojaOciju = "brown";
                m.BojaKose = "black";
                m.KonfBroj = 38;
                m.Visina = 180;
                m.Tezina = 60;

                ModniKreator mk = new ModniKreator();

                mk.Ime = "Mark";
                mk.Prezime = "Ruffalo";
                mk.Pol = "M";
                mk.Zemlja = "Serbia";
                mk.MatBr = 1001;

                Predstavlja predstavlja = new Predstavlja();

                predstavlja.ModniKreator = mk;
                predstavlja.ModnaRevija = mr;
                predstavlja.Kolaborirali = "NE";
                mr.MKreatorNaMReviji.Add(predstavlja);
                mk.Revije.Add(predstavlja);


                mr.Manekeni.Add(m);
                m.ModneRevije.Add(mr);

                s.Save(m);
                s.Flush();
                s.Close();

                MessageBox.Show($"Dodata je modna revija: {mr.Naziv}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateModnaRevija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaRevija.Enitites.ModnaRevija mr = s.Load<ModnaRevija.Enitites.ModnaRevija>(53);

                mr.Naziv = "Modna revija godine";

                s.Save(mr);
                s.Flush();
                s.Close();
                MessageBox.Show($"Naziv je promenjen u: {mr.Naziv}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadModnaRevija_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaRevija.Enitites.ModnaRevija mr = s.Load<ModnaRevija.Enitites.ModnaRevija>(53);

                MessageBox.Show($"Naziv modne revije: {mr.Naziv}");

                foreach(Predstavlja predstavlja in mr.MKreatorNaMReviji)
                {
                    MessageBox.Show($"Modni kreator: {predstavlja.ModniKreator.Ime}");
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelModnaRevija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModnaRevija.Enitites.ModnaRevija mr = s.Load<ModnaRevija.Enitites.ModnaRevija>(53);

                s.Delete(mr);
                s.Flush();
                s.Close();
                MessageBox.Show("Modna revija je obrisana");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdatePredstavlja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavlja p = s.Load<Predstavlja>(45);

                p.Kolaborirali = "DA";

                s.Save(p);
                s.Flush();
                s.Close();
                MessageBox.Show($"Vrednost kolaborirali promenjena je u: {p.Kolaborirali}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavlja p = s.Load<Predstavlja>(45);

                MessageBox.Show($"Na reviji {p.ModnaRevija.Naziv} ucestvuje kreator {p.ModniKreator.Ime}");

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelPredstavlja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavlja p = s.Load<Predstavlja>(45);

                s.Delete(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpecGost sg = new SpecGost();
                sg.ImeGosta = "Morph";
                sg.PrezimeGosta = "Hello";
                sg.Zanimanje = "Actor";

                ModnaRevija.Enitites.ModnaRevija mr = s.Load<ModnaRevija.Enitites.ModnaRevija>(24);

                sg.Gostuje = mr;
                mr.SpecijalniGosti.Add(sg);

                s.Save(sg);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadSpecijalniGost_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpecGost sg = s.Load<SpecGost>(39);

                MessageBox.Show($"Ime gosta je: {sg.ImeGosta}");

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateSpecijalniGost_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpecGost sg = s.Load<SpecGost>(39);

                sg.ImeGosta = "Milan";

                s.Save(sg);
                s.Flush();
                s.Close();
                MessageBox.Show($"Ime gosta je promenjeno u: {sg.ImeGosta}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisiSpecijalnogGosta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpecGost sg = s.Load<SpecGost>(39);

                s.Delete(sg);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddZemlje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Internacionalna i = s.Load<Internacionalna>(2002);

                Zemlje z = new Zemlje();
                z.Naziv = "Zimbabwe";

                z.InternacionalnaMAgencija = i;
                i.Zemlje.Add(z);

                s.Save(z);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateZemlje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zemlje z = s.Load<Zemlje>(26);

                z.Naziv = "Zambezi";


                s.Save(z);
                s.Flush();
                s.Close();

                MessageBox.Show($"Zemlja je promenjena u: {z.Naziv}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadZemlje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zemlje z = s.Load<Zemlje>(26);

                MessageBox.Show($"Naziv zemlje: {z.Naziv}");

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelZemlje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zemlje z = s.Load<Zemlje>(26);

                s.Delete(z);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddModniKreator_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

     
                ModniKreator mk = new ModniKreator();

                mk.Ime = "Mark";
                mk.Prezime = "Ruffalo";
                mk.Pol = "M";
                mk.Zemlja = "Serbia";
                mk.MatBr = 1007;

                Kuce k = new Kuce();

                k.Naziv = "Supreme";

                k.ModniKreator = mk;

                mk.Kuce.Add(k);

                s.Save(mk);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateModniKreator_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModniKreator mk = s.Load<ModniKreator>(1007);

                mk.Ime = "Petar";

                s.Save(mk);
                s.Flush();
                s.Close();
                MessageBox.Show($"Ime je promenjeno u: {mk.Ime}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModniKreator mk = s.Load<ModniKreator>(1007);

                MessageBox.Show($"Ime kreatora je {mk.Ime}, prezime kreatora je {mk.Prezime}");

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ModniKreator mk = s.Load<ModniKreator>(1007);

                s.Delete(mk);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
