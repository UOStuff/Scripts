// Automatically generated by the
// AddonGenerator script by Arya
// Generator edited 10.Mar.07 by Papler
using System;
using Server;
using Server.Items;
namespace Server.Items
{
	public class HalloweenTreeRedAddon : BaseAddon {
		public override BaseAddonDeed Deed{get{return new HalloweenTreeRedAddonDeed();}}
		[ Constructable ]
		public HalloweenTreeRedAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 6941 );
			AddComponent( ac, 2, 0, 4 );

			ac = new AddonComponent( 7598 );
			AddComponent( ac, 1, 1, 22 );

			ac = new AddonComponent( 6869 );
			ac.Hue = 1103;
			AddComponent( ac, 1, 1, 21 );

			ac = new AddonComponent( 6922 );
			AddComponent( ac, 1, 0, 0 );

			ac = new AddonComponent( 6869 );
			ac.Hue = 1103;
			AddComponent( ac, 1, -1, 23 );

			ac = new AddonComponent( 6928 );
			AddComponent( ac, 1, -1, 0 );

			ac = new AddonComponent( 6881 );
			AddComponent( ac, 1, -1, 25 );

			ac = new AddonComponent( 6924 );
			AddComponent( ac, 0, 1, 0 );

			ac = new AddonComponent( 8778 );
			ac.Hue = 1157;
			AddComponent( ac, 0, 0, 0 );

			ac = new AddonComponent( 6923 );
			AddComponent( ac, 0, -1, 0 );

			ac = new AddonComponent( 6926 );
			AddComponent( ac, -1, 1, 0 );

			ac = new AddonComponent( 6927 );
			AddComponent( ac, -1, 0, 0 );


		}
		public HalloweenTreeRedAddon( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){base.Serialize( writer );writer.Write( 0 );}
		public override void Deserialize( GenericReader reader ){base.Deserialize( reader );reader.ReadInt();}
	}

	public class HalloweenTreeRedAddonDeed : BaseAddonDeed {
		public override BaseAddon Addon{get{return new HalloweenTreeRedAddon();}}
		[Constructable]
		public HalloweenTreeRedAddonDeed(){Name = "HalloweenTreeRed";}
		public HalloweenTreeRedAddonDeed( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){	base.Serialize( writer );writer.Write( 0 );}
		public override void	Deserialize( GenericReader reader )	{base.Deserialize( reader );reader.ReadInt();}
	}
}