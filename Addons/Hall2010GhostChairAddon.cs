/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class Hall2010GhostChairAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Hall2010GhostChairAddonDeed();
			}
		}

		[ Constructable ]
		public Hall2010GhostChairAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9537 );
			ac.Hue = 2723;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 9536 );
			ac.Hue = 2723;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2854 );
			ac.Light = LightType.Circle225;
			ac.Hue = 2624;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 9546 );
			ac.Hue = 2723;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 3096 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2854 );
			ac.Light = LightType.Circle225;
			ac.Hue = 2624;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1 );
			ac.Hue = 2723;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 4071 );
			ac.Hue = 2723;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 4072 );
			ac.Hue = 2723;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 4075 );
			ac.Hue = 2723;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 4070 );
			ac.Hue = 2723;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 4074 );
			ac.Hue = 2723;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 4078 );
			ac.Hue = 2723;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 4073 );
			ac.Hue = 2723;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 4076 );
			ac.Hue = 2723;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 4077 );
			ac.Hue = 2723;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 3232 );
			ac.Hue = 2694;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 3235 );
			ac.Hue = 2694;
			AddComponent( ac, 1, -1, 0 );

		}

		public Hall2010GhostChairAddon( Serial serial ) : base( serial )
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

	public class Hall2010GhostChairAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Hall2010GhostChairAddon();
			}
		}

		[Constructable]
		public Hall2010GhostChairAddonDeed()
		{
			Name = "Hall2010GhostChair";
		}

		public Hall2010GhostChairAddonDeed( Serial serial ) : base( serial )
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