
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
	public class DisplayCaseWE3Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2816, 2, 0, 0}, {2817, 1, 0, 0}, {2817, 0, 0, 0}// 1	2	3	
			, {2818, -1, 0, 0}, {2815, -1, 0, 3}, {2814, 0, 0, 3}// 4	5	6	
			, {2814, 1, 0, 3}, {2813, 2, 0, 3}// 7	8	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DisplayCaseWE3AddonDeed();
			}
		}

		[ Constructable ]
		public DisplayCaseWE3Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public DisplayCaseWE3Addon( Serial serial ) : base( serial )
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

	public class DisplayCaseWE3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DisplayCaseWE3Addon();
			}
		}

		[Constructable]
		public DisplayCaseWE3AddonDeed()
		{
			Name = "DisplayCaseWE3";
		}

		public DisplayCaseWE3AddonDeed( Serial serial ) : base( serial )
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