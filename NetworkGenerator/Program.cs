using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace NetworkGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var network = GenerateNetwork();
            var json = new JavaScriptSerializer().Serialize(network);
            var path = System.IO.Directory.GetCurrentDirectory();
            path = System.IO.Path.Combine(path, "network.json");
            System.IO.File.WriteAllText(path, json);
        }

        private static Network GenerateNetwork()
        {
            return new Network() {
                Assets = new List<Asset>() {
                    new Asset() {
                        Id = 1,
                        Code = "LC",
                        Name = "Lamp column"
                    },
                    new Asset() {
                        Id = 2,
                        Code = "SG",
                        Name = "Sign"
                    },
                    new Asset() {
                        Id = 3,
                        Code = "BR",
                        Name = "Bridge"
                    },
                    new Asset() {
                        Id = 4,
                        Code = "SB",
                        Name = "Safety Barrier"
                    }
                },
                Sections = new List<Section>() {
                    new Section() {
                        Id = 1,
                        Label = "A1/101",
                        Length = 125
                    },
                    new Section() {
                        Id = 2,
                        Label = "A1/103",
                        Length = 155
                    },
                    new Section() {
                        Id = 3,
                        Label = "A1/105",
                        Length = 45
                    },
                    new Section() {
                        Id = 4,
                        Label = "A1/107",
                        Length = 255
                    },
                    new Section() {
                        Id = 5,
                        Label = "A55/102",
                        Length = 75
                    },
                    new Section() {
                        Id = 6,
                        Label = "A55/104",
                        Length = 355
                    },
                    new Section() {
                        Id = 7,
                        Label = "M40/211",
                        Length = 525
                    },
                    new Section() {
                        Id = 8,
                        Label = "M40/215",
                        Length = 750
                    },
                    new Section() {
                        Id = 9,
                        Label = "M40/219",
                        Length = 1250
                    },
                    new Section() {
                        Id = 10,
                        Label = "M40/221",
                        Length = 1550
                    },
                }
            };
        }
    }
}
