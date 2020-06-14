
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace FireworksStandEast
{
	public class FireworksStandEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1824, 0, 3, 10}, {1824, 0, 3, 15}, {1824, 0, 2, 10}// 1	2	4	
			, {1824, 0, 2, 15}, {1824, 0, 1, 10}, {1824, 0, 1, 15}// 5	6	7	
			, {1824, 0, 0, 10}, {1824, 0, 0, 15}, {1824, 0, -1, 10}// 8	9	10	
			, {1824, 0, -1, 15}, {1824, 0, -2, 10}, {1824, 0, -2, 15}// 11	16	17	
			, {1824, 0, -3, 10}, {1824, 0, -3, 15}, {3570, 0, 2, 20}// 18	19	28	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FireworksStandEastAddonDeed();
			}
		}

		[ Constructable ]
		public FireworksStandEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 6238, 0, 3, 20, 0, -1, "Pyro Technic Kit", 1);// 3
			AddComplexComponent( (BaseAddon) this, 4835, 1, 3, 0, 2466, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 4835, 1, 2, 0, 2461, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 4835, 1, 1, 0, 1261, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 4835, 1, 0, 0, 2466, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 4835, 1, -1, 0, 2461, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 4835, 1, -2, 0, 1261, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 18662, 0, 3, 20, 2466, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 18662, 0, 2, 20, 2461, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 18662, 0, 1, 20, 1261, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 18662, 0, 0, 20, 2466, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 18662, 0, -1, 20, 2461, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 18662, 0, -2, 20, 1261, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 7986, 0, 1, 20, 1355, -1, "Fireworks Scroll", 1);// 29
			AddComplexComponent( (BaseAddon) this, 2579, 0, 0, 20, 1269, 0, "a Mandrake Root Firework", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2579, 0, -1, 20, 1150, 0, "a Garlic Firework", 1);// 31
			AddComplexComponent( (BaseAddon) this, 2579, 0, -2, 20, 1281, 0, "a Ginseng Firework", 1);// 32
			AddComplexComponent( (BaseAddon) this, 6812, 0, -3, 20, 1172, -1, "a blood moss large sparkler", 1);// 33

		}

		public FireworksStandEastAddon( Serial serial ) : base( serial )
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

	public class FireworksStandEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FireworksStandEastAddon();
			}
		}

		[Constructable]
		public FireworksStandEastAddonDeed()
		{
			Name = "FireworksStandEast";
		}

		public FireworksStandEastAddonDeed( Serial serial ) : base( serial )
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