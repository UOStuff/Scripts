
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class Altar2SouthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1955, -1, -1, 0}, {1955, 0, -1, 0}, {1955, 1, -1, 0}// 15	16	17	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Altar2SouthAddonDeed();
			}
		}

		[ Constructable ]
		public Altar2SouthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 225, -3, -1, 0, 0, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 225, -3, 0, 0, 0, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 225, -3, 1, 0, 0, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1956, -1, 1, 0, 0, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1956, 0, 1, 0, 0, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1956, 1, 1, 0, 0, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1961, 2, 1, 0, 0, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1963, -2, 1, 0, 0, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1965, 2, 0, 0, 0, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1967, -2, 0, 0, 0, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1955, -1, 0, 0, 0, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1955, 0, 0, 0, 0, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1955, 1, 0, 0, 0, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1955, -2, -1, 0, 0, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1955, 2, -1, 0, 0, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1955, -1, -1, 4, 0, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1955, 0, -1, 4, 0, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1955, 1, -1, 4, 0, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 219, -2, -1, 5, 0, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 219, 2, -1, 5, 0, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 224, 3, 1, 0, 0, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 224, 3, 0, 0, 0, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 224, 3, -1, 0, 0, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 3633, -1, -1, 9, 0, 1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 3633, 1, -1, 9, 0, 1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 6571, -1, -1, 16, 0, 1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 6571, 1, -1, 16, 0, 1, "", 1);// 30

		}

		public Altar2SouthAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class Altar2SouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Altar2SouthAddon();
			}
		}

		[Constructable]
		public Altar2SouthAddonDeed()
		{
			Name = "Altar2South";
		}

		public Altar2SouthAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}