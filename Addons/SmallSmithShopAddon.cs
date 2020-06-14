
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
	public class SmallSmithShopAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4015, 0, 3, 0}, {6539, 0, 0, 0}, {6537, 0, -1, 0}// 1	2	3	
			, {6549, 0, 2, 0}, {6551, 0, 1, 0}, {5453, 1, 3, 0}// 4	5	6	
			, {4024, 1, 2, 0}, {7147, 0, -2, 0}, {7159, 0, -2, 2}// 7	8	9	
			, {7141, 0, -2, 4}, {7153, 0, -2, 6}, {4022, 1, -1, 0}// 10	11	12	
			, {4020, 1, 0, 0}, {4028, 1, 1, 0}// 13	14	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SmallSmithShopAddonDeed();
			}
		}

		[ Constructable ]
		public SmallSmithShopAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public SmallSmithShopAddon( Serial serial ) : base( serial )
		{
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

	public class SmallSmithShopAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SmallSmithShopAddon();
			}
		}

		[Constructable]
		public SmallSmithShopAddonDeed()
		{
			Name = "SmallSmithShop";
		}

		public SmallSmithShopAddonDeed( Serial serial ) : base( serial )
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