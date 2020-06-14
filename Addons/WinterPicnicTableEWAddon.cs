
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
	public class WinterPicnicTableEWAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2933, -1, 1, 0}, {2933, 0, 1, 0}, {2938, -1, 0, 0}// 1	2	3	
			, {2938, 0, 0, 0}, {2938, -1, -1, 0}, {2938, 0, -1, 0}// 4	5	6	
			, {2934, -1, -2, 0}, {2934, 0, -2, 0}, {2911, 1, 1, 0}// 7	8	9	
			, {2911, -2, 1, 0}, {2913, 1, -1, 0}, {2913, 1, 0, 0}// 10	11	12	
			, {2913, -2, -1, 0}, {2913, -2, 0, 0}, {2912, -2, -2, 0}// 13	14	15	
			, {2912, 1, -2, 0}, {9354, -1, -1, 1}, {6077, -1, -1, 5}// 16	17	18	
			, {6077, -1, 0, 5}, {6077, 0, 0, 5}, {6077, 0, -1, 5}// 19	20	21	
			, {6091, -1, -2, 5}, {6091, 0, -2, 5}, {6089, -1, 1, 5}// 22	23	24	
			, {6089, 0, 1, 5}, {11229, 1, 0, 17}, {11230, 1, 0, 17}// 25	28	29	
			, {6093, 2, 0, 40}, {6093, 0, 0, 35}, {6093, 0, 2, 35}// 31	32	33	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WinterPicnicTableEWAddonDeed();
			}
		}

		[ Constructable ]
		public WinterPicnicTableEWAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9009, -1, 1, 7, 2293, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 9077, 1, 2, 0, 37, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 3295, 0, 0, 14, 2959, -1, "", 1);// 30

		}

		public WinterPicnicTableEWAddon( Serial serial ) : base( serial )
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

	public class WinterPicnicTableEWAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WinterPicnicTableEWAddon();
			}
		}

		[Constructable]
		public WinterPicnicTableEWAddonDeed()
		{
			Name = "WinterPicnicTableEW";
		}

		public WinterPicnicTableEWAddonDeed( Serial serial ) : base( serial )
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