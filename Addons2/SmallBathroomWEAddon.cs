
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
	public class SmallBathroomWEAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4550, 1, 0, 0}, {7608, 1, 0, 1}, {4174, 1, 0, 0}// 1	2	3	
			, {4239, 2, 0, 7}, {1801, -2, 0, 0}, {1801, -1, 0, 0}// 4	5	6	
			, {1801, 0, 0, 0}, {4104, -2, 0, 5}, {4978, -1, 0, 5}// 7	9	10	
			, {3622, 0, 0, 5}, {3625, 0, 0, 5}, {3626, 0, 0, 5}// 12	13	14	
			, {3628, 0, 0, 5}// 15	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SmallBathroomWEAddonDeed();
			}
		}

		[ Constructable ]
		public SmallBathroomWEAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9229, -2, 0, 4, 2997, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 5986, -1, 0, 5, 2662, -1, "", 1);// 11

		}

		public SmallBathroomWEAddon( Serial serial ) : base( serial )
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

	public class SmallBathroomWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SmallBathroomWEAddon();
			}
		}

		[Constructable]
		public SmallBathroomWEAddonDeed()
		{
			Name = "SmallBathroomWE";
		}

		public SmallBathroomWEAddonDeed( Serial serial ) : base( serial )
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