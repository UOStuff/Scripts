
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
	public class lightwoodeastdeskAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1824, 0, -2, 0}, {1824, 1, -2, 0}, {1824, 0, 2, 0}// 1	2	3	
			, {1824, 1, 2, 0}, {1981, 1, 1, 3}, {1981, 1, 0, 3}// 4	5	6	
			, {1981, 1, -1, 3}// 7	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new lightwoodeastdeskAddonDeed();
			}
		}

		[ Constructable ]
		public lightwoodeastdeskAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public lightwoodeastdeskAddon( Serial serial ) : base( serial )
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

	public class lightwoodeastdeskAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new lightwoodeastdeskAddon();
			}
		}

		[Constructable]
		public lightwoodeastdeskAddonDeed()
		{
			Name = "lightwoodeastdesk";
		}

		public lightwoodeastdeskAddonDeed( Serial serial ) : base( serial )
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