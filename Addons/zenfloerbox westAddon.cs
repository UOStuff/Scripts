
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
	public class zenfloerboxwestAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {13001, 0, 0, 0}, {2834, -1, 2, 0}, {2832, -1, 0, 0}// 1	2	3	
			, {2821, 0, 0, 0}, {2819, 0, 2, 0}, {2835, 1, 0, 0}// 4	5	6	
			, {13001, 0, 1, 0}, {2833, 1, 2, 0}, {2838, -1, 1, 0}// 9	10	11	
			, {2820, 0, 1, 0}, {2836, 1, 1, 0}, {13001, 0, 2, 0}// 13	15	18	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new zenfloerboxwestAddonDeed();
			}
		}

		[ Constructable ]
		public zenfloerboxwestAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9328, 0, 0, 0, 2116, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 9327, 0, 1, 0, 2116, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 3252, 1, 0, 3, 2117, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 3252, 1, 2, 3, 2117, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 3252, 1, 1, 3, 2117, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 9326, 0, 2, 3, 2116, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 3343, 0, -1, 0, 2117, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 3343, 0, 2, 0, 2117, -1, "", 1);// 20

		}

		public zenfloerboxwestAddon( Serial serial ) : base( serial )
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

	public class zenfloerboxwestAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new zenfloerboxwestAddon();
			}
		}

		[Constructable]
		public zenfloerboxwestAddonDeed()
		{
			Name = "zenfloerbox west";
		}

		public zenfloerboxwestAddonDeed( Serial serial ) : base( serial )
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