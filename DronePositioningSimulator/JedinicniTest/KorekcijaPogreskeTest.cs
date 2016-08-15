using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DronePositioningSimulator;

namespace JedinicniTest
{
    [TestClass]
    public class KorekcijaPogreskeTest
    {
        KorekcijaPogreske kp = new KorekcijaPogreske();

        [TestMethod]
        public void izracunajUdaljenostTest()
        {
            double r = Math.Round(kp.izracunajUdaljenost(20, 20, 30, 100),2);
            Assert.AreEqual(80.62, r, "Udaljenost nije tocna!");
        }

        [TestMethod]
        public void izracunajPrimljeniSignalTest()
        {
            double R = Math.Round(kp.izracunajPrimljeniSignal(80.6226f), 2);
            Assert.AreEqual(-39.79, R, "Signal nije dobro izracunat!");
        }

        [TestMethod]
        public void izracunajUdaljenostPomocuSignalaTest()
        {
            double r = Math.Round(kp.izracunajUdaljenostPomocuSignala(-39.79f), 2);
            Assert.AreEqual(80.57, r, "Izracunata udaljenost nije tocna!");
        }

        [TestMethod]
        public void izracunajKorigiraniXTest()
        {
            double x = Math.Round(kp.izracunajKorigiraniX(80.57f, 30, 100, 20, 20),2);
            Assert.AreEqual(-20.01, x, "Korigirani X nije tocan!");
        }

        [TestMethod]
        public void izracunajKorigiraniYTest()
        {
            double y = Math.Round(kp.izracunajKorigiraniY(30,20,100,20,20), 2);
            Assert.AreEqual(20, y, "Korigirani Y nije tocan!");
        }

        private void dodajTockeUListu()
        {
            kp.listaTocaka.Clear();
            var t = new KorekcijaPogreske.tocka();
            t.x = 20.01f;
            t.y = 20.08f;
            kp.listaTocaka.Add(t);
            var t2 = new KorekcijaPogreske.tocka();
            t2.x = 21.97f;
            t2.y = 20.33f;
            kp.listaTocaka.Add(t2);
        }

        [TestMethod]
        public void izracunajProsjekXTest()
        {
            dodajTockeUListu();
            double x = Math.Round(kp.izracunajProsjekX(kp.listaTocaka), 2);
            Assert.AreEqual(20.99, x, "Prosjecni X nije tocan!");
        }

        [TestMethod]
        public void izracunajProsjekYTest()
        {
            dodajTockeUListu();
            double y = Math.Round(kp.izracunajProsjekY(kp.listaTocaka), 2);
            Assert.AreEqual(20.2, y, "Prosjecni Y nije tocan!");
        }
    }
}
