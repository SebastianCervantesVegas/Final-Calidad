using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calidad20222.web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calidad20222.web.Models;

namespace Calidad20222.web.Services.Tests
{
    [TestClass()]
    public class PokerServiceTests
    {
        [TestMethod()]
        public void JugadaTest()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 7,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 2,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("TRIO", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest2()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                    new Carta()
                   {
                       Numero = 7,
                       Palo = "TREBOL"
                    },
                   new Carta()
                   {
                        Numero = 2,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("TRIO", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest3()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                  new Carta()
                   {
                       Numero = 7,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("TRIO", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest4()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                 new Carta()
                   {
                       Numero = 12,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 12,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 12,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 12,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("POKER", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest5()
        {
            List<Carta> cartaList = new List<Carta>()
            {
               new Carta()
                   {
                       Numero = 10,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 5,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("POKER", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest6()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 8,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 9,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 9,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("DOBLE_PAREJA", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest7()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 2,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 2,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 3,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 4,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("DOBLE_PAREJA", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest8()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                 new Carta()
                   {
                       Numero = 7,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 2,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "COCO"
                   },

            };
            Assert.AreNotEqual("COLOR", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest9()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                    new Carta()
                   {
                       Numero = 7,
                       Palo = "CORAZON"
                    },
                   new Carta()
                   {
                        Numero = 2,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("COLOR", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest10()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                   {
                       Numero = 7,
                       Palo = "ESPADA"
                    },
                   new Carta()
                   {
                        Numero = 2,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "ESPADA"
                   },

            };
            Assert.AreNotEqual("COLOR", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest11()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                   {
                       Numero = 7,
                       Palo = "TREBOL"
                    },
                   new Carta()
                   {
                        Numero = 2,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "TREBOL"
                   },

            };
            Assert.AreNotEqual("COLOR", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest12()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                      new Carta()
                   {
                       Numero = 7,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 11,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 9,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("DOBLE", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest13()
        {
            List<Carta> cartaList = new List<Carta>()
            {
               new Carta()
                   {
                       Numero = 2,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 2,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("DOBLE", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest14()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                   {
                       Numero = 13,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 13,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 2,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("DOBLE", cartaList);
        }
        [TestMethod()]
        public void JugadaTest15()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                      new Carta()
                   {
                       Numero = 8,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 9,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("DOBLE", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest16()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                        new Carta()
                   {
                       Numero = 10,
                       Palo = "CORAZON"
                    },
                   new Carta()
                   {
                        Numero = 9,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 6,
                        Palo = "ESPADA"
                   },

            };
            Assert.AreNotEqual("ESCALERA", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest17()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                    new Carta()
                   {
                       Numero = 11,
                       Palo = "CORAZON"
                    },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 9,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "ESPADA"
                   },

            };
            Assert.AreNotEqual("ESCALERA", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest18()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                     new Carta()
                   {
                       Numero = 12,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 11,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 9,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("ESCALERA", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest19()
        {
            List<Carta> cartaList = new List<Carta>()
            {
               new Carta()
                   {
                       Numero = 7,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("FULL", cartaList); 
        }
        [TestMethod()]
        public void JugadaTest20()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 10,
                       Palo = "COCO"
                    },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 10,
                        Palo = "COCO"
                   },
                   new Carta()
                   {
                        Numero = 12,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 12,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("FULL", cartaList);
        }
    }
}