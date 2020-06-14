
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
	public class poisonwellAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {7420, -1, -2, 6}, {5940, 0, 0, 0}, {6883, -1, 0, 6}// 3	7	9	
			, {4652, -1, 0, 6}, {5701, 1, -1, 6}, {7411, 2, 0, 1}// 10	12	16	
			, {6926, 0, 2, 6}, {6884, 2, -1, 6}, {4653, -1, 1, 6}// 17	18	19	
			, {6923, 1, 0, 0}, {4309, -1, 0, 6}, {4650, -1, 2, 0}// 24	25	27	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new poisonwellAddonDeed();
			}
		}

		[ Constructable ]
		public poisonwellAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 5952, -2, -2, 0, 268, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 5943, 1, -2, 0, 268, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 5944, 0, -2, 0, 268, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 5977, -1, -2, 0, 268, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 5948, -2, 0, 0, 268, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 5950, -1, -1, 0, 268, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 5945, 0, -1, 0, 268, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 5942, 1, -1, 0, 268, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 5939, 0, 1, 0, 268, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 5975, -2, -1, 0, 268, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 5947, -1, 0, 0, 268, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 5938, -1, 1, 0, 268, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 5937, -2, 1, 0, 268, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 5941, 1, 0, 0, 268, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 5946, 0, 0, 0, 268, -1, "", 1);// 26

		}

		public poisonwellAddon( Serial serial ) : base( serial )
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

	public class poisonwellAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new poisonwellAddon();
			}
		}

		[Constructable]
		public poisonwellAddonDeed()
		{
			Name = "poisonwell";
		}

		public poisonwellAddonDeed( Serial serial ) : base( serial )
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