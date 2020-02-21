using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClasses
{
    enum HeldType { Barbaar, Dwerg, Elf, Tovenaar }
    class Held
    {
        public Held(HeldType type,string naam)
        {
            Naam = naam;
            HeldType = type;

            switch (HeldType)
            {
                case HeldType.Barbaar:
                    AanvalsDobbelstenen = 3;
                    MaxInteligentie = 2;
                    MaxLichaam = 8;
                    break;
                case HeldType.Dwerg:
                    MaxInteligentie = 3;
                    MaxInteligentie = 7;

                    break;
                case HeldType.Elf:
                    MaxInteligentie = 4;
                    MaxLichaam = 6;

                    break;
                case HeldType.Tovenaar:
                    AanvalsDobbelstenen =1;
                    MaxInteligentie = 6;
                    MaxLichaam = 4;

                    break;
                default:
                    break;
            }
            HuidigInteligentie = MaxLichaam;
            HuidigLichaam = MaxLichaam;
        }

        

        public string  Naam { get; set; }
        public string Beschrijving { get;private set; }
        public int MaxInteligentie { get; private set; }
        public int MaxLichaam { get; private set; }
        public int HuidigInteligentie { get; set; }
        public int HuidigLichaam { get; set; }
        public HeldType HeldType { get; private set; }
        public int AanvalsDobbelstenen { get; private set; } = 2;
        public int VerdedegingsDobbbelstenen { get;private set; } = 2;
        public int LoopDobbelstenen { get; private set; } = 2;



        

    }
}
