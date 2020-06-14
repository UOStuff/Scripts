
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
	public class MediumKitchenSWAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1801, -2, -2, 0}, {1801, -2, -2, 5}, {11599, -2, -2, 10}// 1	2	3	
			, {1824, -2, 0, 0}, {1824, 1, -1, 0}, {1824, -2, -1, 0}// 4	5	6	
			, {1824, 1, 0, 0}, {4100, -2, 0, 11}, {4239, -1, -2, 4}// 7	8	9	
			, {4104, -2, 0, 5}, {1824, -2, 1, 0}, {3130, -2, 1, 0}// 10	11	12	
			, {3135, -2, 1, 0}, {3137, -2, 1, 0}, {1824, -2, 2, 0}// 13	14	15	
			, {1824, -1, 2, 0}, {2460, -1, 2, 5}, {6527, 0, 2, 0}// 16	17	18	
			, {6530, 1, 2, 0}, {7817, 1, 2, 7}, {1824, 2, 2, 0}// 20	22	23	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MediumKitchenSWAddonDeed();
			}
		}

		[ Constructable ]
		public MediumKitchenSWAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3530, 0, 2, 7, 1, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 3530, 1, 2, 7, 1, -1, "", 1);// 21

		}

		public MediumKitchenSWAddon( Serial serial ) : base( serial )
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

	public class MediumKitchenSWAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MediumKitchenSWAddon();
			}
		}

		[Constructable]
		public MediumKitchenSWAddonDeed()
		{
			Name = "MediumKitchenSW";
		}

		public MediumKitchenSWAddonDeed( Serial serial ) : base( serial )
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