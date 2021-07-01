using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using ModnaRevijaLibrary.DTOs;
using ModnaRevijaLibrary.Enitites;
using System.Linq;
using NHibernate.Stat;

namespace ModnaRevijaLibrary
{
    public class DataProvider
    {
        #region ModnaRevija
        public static List<ModnaRevijaView> VratiSveModneRevije()
        {
            List<ModnaRevijaView> modnerevije = new List<ModnaRevijaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ModnaRevija> sveModneRevije = from o in s.Query<ModnaRevija>()
                                                          select o;
                foreach (ModnaRevija mr in sveModneRevije)
                {
                    modnerevije.Add(new ModnaRevijaView(mr));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return modnerevije;
        }

        public static ModnaRevijaView VratiModnuReviju(int id)
        {
            ModnaRevijaView modnarevijaView;
            try
            {
                ISession s = DataLayer.GetSession();
                ModnaRevija o = s.Load<ModnaRevija>(id);
                modnarevijaView = new ModnaRevijaView(o);
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return modnarevijaView;
        }

        public static void DodajModnuReviju(ModnaRevijaView mr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ModnaRevija o = new ModnaRevija
                {
                    Rbr = mr.Rbr,
                    Naziv = mr.Naziv,
                    Mesto = mr.Mesto,
                    DatumVremeOdrzavanja = mr.DatumVremeOdrzavanja
                };
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static ModnaRevijaView AzurirajModnuReviju(ModnaRevijaView mr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ModnaRevija o = new ModnaRevija
                {
                    Rbr = mr.Rbr,
                    Naziv = mr.Naziv,
                    Mesto = mr.Mesto,
                    DatumVremeOdrzavanja = mr.DatumVremeOdrzavanja
                };
                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return mr;
        }

        public static void ObrisiModnuReviju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ModnaRevija o = s.Load<ModnaRevija>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        #endregion

        #region Ucesnik
        public static List<UcesnikView> VratiSveUcesnike()
        {
            List<UcesnikView> ucesnici = new List<UcesnikView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Ucesnik> sviUcesnici = from o in s.Query<Ucesnik>()
                                                   select o;
                foreach (Ucesnik u in sviUcesnici)
                {
                    ucesnici.Add(new UcesnikView(u));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return ucesnici;
        }

        public static UcesnikView VratiUcesnika(int id)
        {
            UcesnikView ucesnikView;
            try
            {
                ISession s = DataLayer.GetSession();
                Ucesnik u = s.Load<Ucesnik>(id);
                ucesnikView = new UcesnikView(u);
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return ucesnikView;
        }

        public static void ObrisiUcesnika(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ucesnik u = s.Load<Ucesnik>(id);
                s.Delete(u);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        #endregion

        #region ModniKreator
        public static List<ModniKreatorView> VratiSveModneKreatore()
        {
            List<ModniKreatorView> modniKreatori = new List<ModniKreatorView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ModniKreator> sviModniKreatori = from o in s.Query<ModniKreator>()
                                                             select o;
                foreach (ModniKreator mk in sviModniKreatori)
                {
                    modniKreatori.Add(new ModniKreatorView(mk));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return modniKreatori;
        }

        public static ModniKreatorView VratiModnogKreatora(int id)
        {
            ModniKreatorView modniKreatorView;
            try
            {
                ISession s = DataLayer.GetSession();
                ModniKreator mk = s.Load<ModniKreator>(id);
                modniKreatorView = new ModniKreatorView(mk);
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return modniKreatorView;
        }

        public static void DodajModnogKreatora(ModniKreatorView modnikreator)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ModniKreator mk = new ModniKreator
                {
                    Ime = modnikreator.Ime,
                    Prezime = modnikreator.Prezime,
                    Pol = modnikreator.Pol,
                    DatumRodjenja = modnikreator.DatumRodjenja,
                    Zemlja = modnikreator.Zemlja,
                };
                s.Save(mk);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static ModniKreatorView AzurirajModnogKreatora(ModniKreatorView mk)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ModniKreator modnikreator = s.Load<ModniKreator>(mk.MatBr);
                modnikreator.Ime = mk.Ime;
                modnikreator.Prezime = mk.Prezime;
                modnikreator.Pol = mk.Pol;
                modnikreator.Zemlja = mk.Zemlja;

                s.Update(modnikreator);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return mk;
        }
        #endregion

        #region Maneken
        public static List<ManekenView> VratiSveManekene()
        {
            List<ManekenView> manekeni = new List<ManekenView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Maneken> sviManekeni = from o in s.Query<Maneken>()
                                                   select o;
                foreach (Maneken m in sviManekeni)
                {
                    manekeni.Add(new ManekenView(m));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return manekeni;
        }

        public static ManekenView VratiManekena(int id)
        {
            ManekenView manekenView;
            try
            {
                ISession s = DataLayer.GetSession();
                Maneken m = s.Load<Maneken>(id);
                manekenView = new ManekenView(m);
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return manekenView;
        }

        public static void DodajManekena(ManekenView maneken)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Maneken m = new Maneken
                {
                    Ime = maneken.Ime,
                    Prezime = maneken.Prezime,
                    Pol = maneken.Pol,
                    DatumRodjenja = maneken.DatumRodjenja,
                    BojaOciju = maneken.BojaOciju,
                    BojaKose = maneken.BojaKose,
                    KonfBroj = maneken.KonfBroj,
                    Visina = maneken.Visina,
                    Tezina = maneken.Tezina
                };
                s.Save(m);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static ManekenView AzurirajManekena(ManekenView m)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Maneken maneken = s.Load<Maneken>(m.MatBr);
                maneken.Ime = m.Ime;
                maneken.Prezime = m.Prezime;
                maneken.Pol = m.Pol;
                maneken.BojaOciju = m.BojaOciju;
                maneken.BojaKose = m.BojaKose;
                maneken.KonfBroj = m.KonfBroj;
                maneken.Visina = m.Visina;
                maneken.Tezina = m.Tezina;

                s.Update(maneken);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return m;
        }
        #endregion

        #region ModnaAgencija

        public static List<ModnaAgencijaView> VratiSveModneAgencije()
        {
            List<ModnaAgencijaView> modneagencije = new List<ModnaAgencijaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ModnaAgencija> sveModneAgencije = from o in s.Query<ModnaAgencija>()
                                                              select o;
                foreach (ModnaAgencija ma in sveModneAgencije)
                {
                    modneagencije.Add(new ModnaAgencijaView(ma));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return modneagencije;
        }

        public static ModnaAgencijaView VratiModnuAgenciju(int id)
        {
            ModnaAgencijaView modnaagencijaView;
            try
            {
                ISession s = DataLayer.GetSession();
                ModnaAgencija ma = s.Load<ModnaAgencija>(id);
                modnaagencijaView = new ModnaAgencijaView(ma);
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return modnaagencijaView;
        }

        public static void ObrisiModnuAgenciju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ModnaAgencija o = s.Load<ModnaAgencija>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        #endregion

        #region Internacionalna
        public static List<InternacionalnaView> VratiSveInternacionalne()
        {
            List<InternacionalnaView> internacionalne = new List<InternacionalnaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Internacionalna> sveInternacionalne = from o in s.Query<Internacionalna>()
                                                                  select o;
                foreach (Internacionalna i in sveInternacionalne)
                {
                    internacionalne.Add(new InternacionalnaView(i));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return internacionalne;
        }

        public static InternacionalnaView VratiInternacionalnu(int id)
        {
            InternacionalnaView internacionalnaView;
            try
            {
                ISession s = DataLayer.GetSession();
                Internacionalna i = s.Load<Internacionalna>(id);
                internacionalnaView = new InternacionalnaView(i);
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return internacionalnaView;
        }

        public static void DodajInternacionalnu(InternacionalnaView internacionalna)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Internacionalna i = new Internacionalna
                {
                    Pib = internacionalna.Pib,
                    NazivAgencije = internacionalna.NazivAgencije,
                    Sediste = internacionalna.Sediste,
                    DatumOsnivanja = internacionalna.DatumOsnivanja
                };
                s.Save(i);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static InternacionalnaView AzurirajInternacionalnu(InternacionalnaView i)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Internacionalna internacionalna = s.Load<Internacionalna>(i.Pib);
                internacionalna.Pib = i.Pib;
                internacionalna.NazivAgencije = i.NazivAgencije;
                internacionalna.Sediste = i.Sediste;
                internacionalna.DatumOsnivanja = i.DatumOsnivanja;

                s.Update(internacionalna);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return i;
        }
        #endregion

        #region SpecGost
        public static List<SpecGostView> VratiSveSpecGoste(int modnarevijaID)
        {
            List<SpecGostView> specgosti = new List<SpecGostView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<SpecGost> sviSpecGosti = from o in s.Query<SpecGost>()
                                                     where o.Gostuje.Id == modnarevijaID
                                                     select o;
                foreach (SpecGost sg in sviSpecGosti)
                {
                    specgosti.Add(new SpecGostView(sg));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return specgosti;
        }

        public static List<SpecGostView> VratiSveSpecGosteSaRevijom(int modnarevijaID)
        {
            List<SpecGostView> specgosti = new List<SpecGostView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<SpecGost> sviSpecGosti = from o in s.Query<SpecGost>()
                                                     where o.Gostuje.Id == modnarevijaID
                                                     select o;
                foreach (SpecGost o in sviSpecGosti)
                {
                    var sgsg = new SpecGostView(o)
                    {
                        Gostuje = new ModnaRevijaView(o.Gostuje)
                    };
                    specgosti.Add(sgsg);
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return specgosti;
        }

        public static void PoveziSpecGostaIReviju(int specgostID, int modnarevijaID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpecGost specgost = s.Load<SpecGost>(specgostID);
                ModnaRevija modnarevija = s.Load<ModnaRevija>(modnarevijaID);
                specgost.Gostuje = modnarevija;

                s.Update(specgost);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static SpecGostView VratiSpecGosta(int id)
        {
            SpecGostView specgostView;
            try
            {
                ISession s = DataLayer.GetSession();
                SpecGost o = s.Load<SpecGost>(id);
                specgostView = new SpecGostView(o);
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return specgostView;
        }

        public static void DodajSpecGosta(SpecGostView sg)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpecGost o = new SpecGost
                {
                    Id = sg.Id,
                    ImeGosta = sg.ImeGosta,
                    PrezimeGosta = sg.PrezimeGosta,
                    Zanimanje = sg.Zanimanje
                };
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void DodajSpecGostaSaRevijom(SpecGostView sg)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpecGost o = new SpecGost();
                ModnaRevija mr = s.Load<ModnaRevija>(sg.Gostuje.Id);

                o.Id = sg.Id;
                o.ImeGosta = sg.ImeGosta;
                o.PrezimeGosta = sg.PrezimeGosta;
                o.Zanimanje = sg.Zanimanje;
                o.Gostuje = mr;
                
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static SpecGostView AzurirajSpecGosta(SpecGostView sg)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpecGost o = new SpecGost
                {
                    Id = sg.Id,
                    ImeGosta = sg.ImeGosta,
                    PrezimeGosta = sg.PrezimeGosta,
                    Zanimanje = sg.Zanimanje
                };
                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return sg;
        }

        public static void ObrisiSpecGosta(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpecGost o = s.Load<SpecGost>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        #endregion

        #region Casopisi
        public static List<CasopisiView> VratiSveCasopise(int manekenID)
        {
            List<CasopisiView> casopisi = new List<CasopisiView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Casopisi> sviCasopisi = from o in s.Query<Casopisi>()
                                                    where o.Maneken.MatBr == manekenID
                                                    select o;
                foreach (Casopisi c in sviCasopisi)
                {
                    casopisi.Add(new CasopisiView(c));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return casopisi;
        }

        public static List<CasopisiView> VratiSveCasopiseSaManekenom(int manekenID)
        {
            List<CasopisiView> casopisi = new List<CasopisiView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Casopisi> sviCasopisi = from o in s.Query<Casopisi>()
                                                    where o.Maneken.MatBr == manekenID
                                                    select o;
                foreach (Casopisi c in sviCasopisi)
                {
                    var cscs = new CasopisiView(c)
                    {
                        Maneken = new ManekenView(c.Maneken)
                    };
                    casopisi.Add(cscs);
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return casopisi;
        }

        public static void PoveziCasopiseIManekena(int casopisID, int manekenID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Casopisi casopisi = s.Load<Casopisi>(casopisID);
                Maneken maneken = s.Load<Maneken>(manekenID);
                casopisi.Maneken = maneken;

                s.Update(casopisi);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        #endregion

        #region Kuce
        public static List<KuceView> VratiSveKuce(int kreatorID)
        {
            List<KuceView> kuce = new List<KuceView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Kuce> sveKuce = from o in s.Query<Kuce>()
                                            where o.ModniKreator.MatBr == kreatorID
                                                          select o;
                foreach (Kuce k in sveKuce)
                {
                    kuce.Add(new KuceView(k));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return kuce;
        }

        public static List<KuceView> VratiSveKuceSaKreatorom(int kreatorID)
        {
            List<KuceView> kuce = new List<KuceView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Kuce> sveKuce = from o in s.Query<Kuce>()
                                            where o.ModniKreator.MatBr == kreatorID
                                            select o;
                foreach (Kuce k in sveKuce)
                {
                    var kckc = new KuceView(k)
                    {
                        ModniKreator = new ModniKreatorView(k.ModniKreator)
                    };
                    kuce.Add(kckc);
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return kuce;
        }

        public static void PoveziKuceIKreatora(int kucaID, int kreatorID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Kuce kuce = s.Load<Kuce>(kucaID);
                ModniKreator kreator = s.Load<ModniKreator>(kreatorID);
                kuce.ModniKreator = kreator;

                s.Update(kuce);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        #endregion

        #region Zemlje
        public static List<ZemljeView> VratiSveZemlje(int internacionalnaID)
        {
            List<ZemljeView> zemlje = new List<ZemljeView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Zemlje> sveZemlje = from o in s.Query<Zemlje>()
                                                where o.InternacionalnaMAgencija.Pib == internacionalnaID
                                                          select o;
                foreach (Zemlje z in sveZemlje)
                {
                    zemlje.Add(new ZemljeView(z));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return zemlje;
        }

        public static List<ZemljeView> VratiSveZemljeSaInternacionalnom(int internacionalnaID)
        {
            List<ZemljeView> zemlje = new List<ZemljeView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Zemlje> sveZemlje = from o in s.Query<Zemlje>()
                                                where o.InternacionalnaMAgencija.Pib == internacionalnaID
                                                select o;
                foreach (Zemlje z in sveZemlje)
                {
                    var zmzm = new ZemljeView(z)
                    {
                        InternacionalnaMAgencija = new InternacionalnaView(z.InternacionalnaMAgencija)
                    };
                    zemlje.Add(zmzm);
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return zemlje;
        }

        public static void PoveziZemljeIInternacionalnu(int zemljaID, int internacionalnaID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zemlje zemlje = s.Load<Zemlje>(zemljaID);
                Internacionalna internacionalna = s.Load<Internacionalna>(internacionalnaID);
                zemlje.InternacionalnaMAgencija = internacionalna;

                s.Update(zemlje);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        #endregion

        #region Predstavlja
        public static List<PredstavljaView> VratiSveKreatoreSaRevijama(int id)
        {
            List<PredstavljaView> predstavljanja = new List<PredstavljaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Predstavlja> svaPredstavljanja = from o in s.Query<Predstavlja>()
                                                where o.Prezentuje.Id == id
                                                select o;
                foreach (Predstavlja p in svaPredstavljanja)
                {
                    ModniKreatorView Kreator = VratiModnogKreatora(p.Kreator.MatBr);
                    ModnaRevijaView Prezentuje = VratiModnuReviju(p.Prezentuje.Id);
                    predstavljanja.Add(new PredstavljaView(p));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return predstavljanja;
        }

        public static void DodajPredstavljanje(PredstavljaView predstavlja)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Predstavlja p = new Predstavlja
                {
                    Prezentuje = s.Load<ModnaRevija>(predstavlja.Prezentuje.Id),
                    Kreator = s.Load<ModniKreator>(predstavlja.Kreator.MatBr),
                    Kolaborirali = predstavlja.Kolaborirali     
                };
                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            } 
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        #endregion

        #region Pripada
        public static List<PripadaView> VratiSvaPripadanjaManekena()
        {
            List<PripadaView> pripadanja = new List<PripadaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Pripada> svaPripadanja = from o in s.Query<Pripada>()
                                                   select o;
                foreach (Pripada p in svaPripadanja)
                {
                    pripadanja.Add(new PripadaView(p));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return pripadanja;
        }

        public static void DodajPripadanje(PripadaView pripadanje)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pripada p = new Pripada
                {
                    Id = pripadanje.Id,
                    MatbrManeken = pripadanje.MatbrManeken,
                    PibAgencija = pripadanje.PibAgencija
                };
                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        #endregion

        #region Nastupa
        public static List<NastupaView> VratiSvaNastupanjaManekena()
        {
            List<NastupaView> nastupanja = new List<NastupaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Nastupa> svaNastupanja = from o in s.Query<Nastupa>()
                                                     select o;
                foreach (Nastupa n in svaNastupanja)
                {
                    nastupanja.Add(new NastupaView(n));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return nastupanja;
        }

        public static void DodajNastupanje(NastupaView nastupanje)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Nastupa n = new Nastupa
                {
                    Id = nastupanje.Id,
                    MatbrManeken = nastupanje.MatbrManeken,
                    IdRevija = nastupanje.IdRevija
                };
                s.Save(n);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        #endregion
    }
}
