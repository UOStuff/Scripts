
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
	public class RusticFirePlaceOneAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1315, 0, -1, 0}, {1315, 2, -1, 0}, {37, 1, -1, 0}// 1	2	3	
			, {1315, 1, -1, 0}, {14058, 0, -1, 20}, {3132, 1, -1, 5}// 4	5	7	
			, {3136, 2, -1, 3}, {1315, 1, 0, 0}, {1315, 1, 1, 0}// 8	10	11	
			, {1315, 0, 1, 0}, {38, 0, 0, 0}, {1315, 0, 0, 0}// 12	13	14	
			, {1315, 2, 0, 0}, {7137, 2, 1, 9}, {1315, 2, 1, 0}// 15	16	17	
			, {36, 1, 0, 0}, {1311, 1, 0, 8}, {3131, -1, 0, 0}// 18	19	21	
			, {3135, -1, 1, 0}, {7138, 2, 0, 0}// 22	23	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new RusticFirePlaceOneAddonDeed();
			}
		}

		[ Constructable ]
		public RusticFirePlaceOneAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 157, 0, -1, 7, 2139, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 6571, 2, 1, 13, 0, 29, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2541, 1, 0, 8, 0, -1, "a cauldron", 1);// 20

		}

		public RusticFirePlaceOneAddon( Serial serial ) : base( serial )
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

	public class RusticFirePlaceOneAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new RusticFirePlaceOneAddon();
			}
		}

		[Constructable]
		public RusticFirePlaceOneAddonDeed()
		{
			Name = "RusticFirePlaceOne";
		}

		public RusticFirePlaceOneAddonDeed( Serial serial ) : base( serial )
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