if($GameModeArg !$= "Add-Ons/GameMode_Fastkarts/gamemode.txt" )
{
	warn("GameMode_Fastkarts cannot be used in custom games");
	warn("We'll just load the karts instead...");
	exec("./addons/karts/Karts.cs");
	return;
}

function FK_LoadPrefs()
{
	//records
	deleteVariables("$FK::Record_*");
	
	if(isFile("config/server/FASTKarts/records.cs"))
		exec("config/server/FASTKarts/records.cs");
	else
		warn("Server has no track records.");
	
	///////////////
	//ROUND PREFS//
	///////////////
	
	//rounds per map
	if($Pref::Server::FASTKarts::RoundLimit $= "")
		$Pref::Server::FASTKarts::RoundLimit = 6;
	
	//allow normal rounds
	if($Pref::Server::FASTKarts::NormalRounds $= "")
		$Pref::Server::FASTKarts::NormalRounds = true;
	
	//allow rocket rounds
	if($Pref::Server::FASTKarts::RocketRounds $= "")
		$Pref::Server::FASTKarts::RocketRounds = false;
	
	//allow bouncy rounds
	if($Pref::Server::FASTKarts::BouncyRounds $= "")
		$Pref::Server::FASTKarts::BouncyRounds = false;
	
	///////////////
	//TRACK PREFS//
	///////////////
	
	//true to load tracks in random order, false to load them in numbered order
	if($Pref::Server::FASTKarts::RandomTracks $= "")
		$Pref::Server::FASTKarts::RandomTracks = false;
	
	//allow players to vote for tracks
	if($Pref::Server::FASTKarts::EnableTrackVoting $= "")
		$Pref::Server::FASTKarts::EnableTrackVoting = 1;
	
	/////////////
	//TIP PREFS//
	/////////////
	
	//display a tip every X seconds (-1 disables)
	if($Pref::Server::FASTKarts::TipSeconds $= "")
		$Pref::Server::FASTKarts::TipSeconds = 60;
	
	//////////////////
	//GAMEPLAY PREFS//
	//////////////////
	
	//enable achievements system
	if($Pref::Server::FASTKarts::Achievements $= "")
		$Pref::Server::FASTKarts::Achievements = true;
	
	//crumble players on death
	if($Pref::Server::FASTKarts::CrumbleDeath $= "")
		$Pref::Server::FASTKarts::CrumbleDeath = true;
	
	//do special emitter effects on death
	if($Pref::Server::FASTKarts::PGDieEffects $= "")
		$Pref::Server::FASTKarts::PGDieEffects = true;
	
	//play gag sounds on death
	if($Pref::Server::FASTKarts::PGDieSounds $= "")
		$Pref::Server::FASTKarts::PGDieSounds = true;
	
	//play a random yell on death
	if($Pref::Server::FASTKarts::RandomDeathYells $= "")
		$Pref::Server::FASTKarts::RandomDeathYells = true;
	
	//allow race completion without a vehicle
	if($Pref::Server::FASTKarts::VehiclelessWins $= "")
		$Pref::Server::FASTKarts::VehiclelessWins = false;
	
	//announce in chat when a new record is set
	if($Pref::Server::FASTKarts::AnnounceRecords $= "")
		$Pref::Server::FASTKarts::AnnounceRecords = false;
	
	//show milliseconds where race time left is shown
	if($Pref::Server::FASTKarts::ShowMilliseconds $= "")
		$Pref::Server::FASTKarts::ShowMilliseconds = false;
	
	//kill a player after X seconds if they're not in a vehicle
	if($Pref::Server::FASTKarts::NoKartKillTime $= "")
		$Pref::Server::FASTKarts::NoKartKillTime = 20;
	
	//////////////
	//KART PREFS//
	//////////////
	
	//allow players to play a horn from their karts
	if($Pref::Server::FASTKarts::HornSounds $= "")
		$Pref::Server::FASTKarts::HornSounds = true;
	
	//delay between horns
	if($Pref::Server::FASTKarts::HornMS $= "")
		$Pref::Server::FASTKarts::HornMS = 50;
	
	//have karts play constant engine sounds
	if($Pref::Server::FASTKarts::EngineSounds $= "")
		$Pref::Server::FASTKarts::EngineSounds = true;
	
	//allow players to lean back and forth in their kart
	if($Pref::Server::FASTKarts::BackForwardLeaning $= "")
		$Pref::Server::FASTKarts::BackForwardLeaning = false;
	
	//use kart names that were given in older fastkarts versions
	if($Pref::Server::FASTKarts::OldKartNames $= "")
		$Pref::Server::FASTKarts::OldKartNames = false;
	
	//bypass all above kart prefs and load the default speedkart's karts instead of fastkarts' karts
	if($Pref::Server::FASTKarts::ForceSpeedkarts $= "")
		$Pref::Server::FASTKarts::ForceSpeedkarts = false;
	
	///////////////////////
	//ALLOWED KARTS PREFS//
	///////////////////////
	
	//allow players to pick a speedkart
	if($Pref::Server::FASTKarts::AllowSpeedKart $= "")
		$Pref::Server::FASTKarts::AllowSpeedKart = true;
	
	//allow players to pick a speedkart 64
	if($Pref::Server::FASTKarts::Allow64 $= "")
		$Pref::Server::FASTKarts::Allow64 = true;
	
	//allow players to pick a speedkart 7
	if($Pref::Server::FASTKarts::Allow7 $= "")
		$Pref::Server::FASTKarts::Allow7 = true;
	
	//allow players to pick a speedkart blocko
	if($Pref::Server::FASTKarts::AllowBlocko $= "")
		$Pref::Server::FASTKarts::AllowBlocko = true;
	
	//allow players to pick a speedkart buggy
	if($Pref::Server::FASTKarts::AllowBuggy $= "")
		$Pref::Server::FASTKarts::AllowBuggy = true;
	
	//allow players to pick a speedkart classic
	if($Pref::Server::FASTKarts::AllowClassic $= "")
		$Pref::Server::FASTKarts::AllowClassic = true;
	
	//allow players to pick a speedkart classic gt
	if($Pref::Server::FASTKarts::AllowClassicGT $= "")
		$Pref::Server::FASTKarts::AllowClassicGT = true;
	
	//allow players to pick a speedkart formula
	if($Pref::Server::FASTKarts::AllowFormula $= "")
		$Pref::Server::FASTKarts::AllowFormula = true;
	
	//allow players to pick a speedkart hotrod
	if($Pref::Server::FASTKarts::AllowHotrod $= "")
		$Pref::Server::FASTKarts::AllowHotrod = true;
	
	//allow players to pick a speedkart hyperion
	if($Pref::Server::FASTKarts::AllowHyperion $= "")
		$Pref::Server::FASTKarts::AllowHyperion = true;
	
	//allow players to pick a speedkart jeep
	if($Pref::Server::FASTKarts::AllowJeep $= "")
		$Pref::Server::FASTKarts::AllowJeep = true;
	
	//allow players to pick a speedkart lemans
	if($Pref::Server::FASTKarts::AllowLeMans $= "")
		$Pref::Server::FASTKarts::AllowLeMans = true;
	
	//allow players to pick a speedkart muscle
	if($Pref::Server::FASTKarts::AllowMuscle $= "")
		$Pref::Server::FASTKarts::AllowMuscle = true;
	
	//allow players to pick a speedkart vintage
	if($Pref::Server::FASTKarts::AllowVintage $= "")
		$Pref::Server::FASTKarts::AllowVintage = true;
	
	//allow players to pick a speedkart hover
	if($Pref::Server::FASTKarts::AllowHover $= "")
		$Pref::Server::FASTKarts::AllowHover = true;
	
	//allow players to pick a speedkart original
	if($Pref::Server::FASTKarts::AllowOriginal $= "")
		$Pref::Server::FASTKarts::AllowOriginal = true;
	
	//allow players to pick a speedkart default
	if($Pref::Server::FASTKarts::AllowDefault $= "")
		$Pref::Server::FASTKarts::AllowDefault = true;
	
	//allow players to pick a superkart
	if($Pref::Server::FASTKarts::AllowSuperKart $= "")
		$Pref::Server::FASTKarts::AllowSuperKart = true;
	
	//allow players to pick a superkart atv
	if($Pref::Server::FASTKarts::AllowSuperATV $= "")
		$Pref::Server::FASTKarts::AllowSuperATV = true;
	
	//allow players to pick a superkart hover
	if($Pref::Server::FASTKarts::AllowSuperHover $= "")
		$Pref::Server::FASTKarts::AllowSuperHover = true;
	
	//allow players to pick a superkart jetski
	if($Pref::Server::FASTKarts::AllowSuperJetski $= "")
		$Pref::Server::FASTKarts::AllowSuperJetski = true;
	
	//allow players to pick a superkart plane
	if($Pref::Server::FASTKarts::AllowSuperPlane $= "")
		$Pref::Server::FASTKarts::AllowSuperPlane = true;
	
	///////////////
	//ADDON PREFS//
	///////////////
	
	//allows players to load music from their custom gamemode
	if($Pref::Server::FASTKarts::LoadCustomMusic $= "")
		$Pref::Server::FASTKarts::LoadCustomMusic = false;
	
	//addons to load after gamemode execution, only works with addons that have a server.cs, and that's executed directly.
	if($Pref::Server::FASTKarts::LoadAddon1 $= "")
		$Pref::Server::FASTKarts::LoadAddon1 = "";
	
	if($Pref::Server::FASTKarts::LoadAddon2 $= "")
		$Pref::Server::FASTKarts::LoadAddon2 = "";
	
	if($Pref::Server::FASTKarts::LoadAddon3 $= "")
		$Pref::Server::FASTKarts::LoadAddon3 = "";
	
	if($Pref::Server::FASTKarts::LoadAddon4 $= "")
		$Pref::Server::FASTKarts::LoadAddon4 = "";
	
	if($Pref::Server::FASTKarts::LoadAddon5 $= "")
		$Pref::Server::FASTKarts::LoadAddon5 = "";
	
	if($Pref::Server::FASTKarts::LoadAddon6 $= "")
		$Pref::Server::FASTKarts::LoadAddon6 = "";
	
	if($Pref::Server::FASTKarts::LoadAddon7 $= "")
		$Pref::Server::FASTKarts::LoadAddon7 = "";
	
	if($Pref::Server::FASTKarts::LoadAddon8 $= "")
		$Pref::Server::FASTKarts::LoadAddon8 = "";
	
	if($Pref::Server::FASTKarts::LoadAddon9 $= "")
		$Pref::Server::FASTKarts::LoadAddon9 = "";
	
	if($Pref::Server::FASTKarts::LoadAddon10 $= "")
		$Pref::Server::FASTKarts::LoadAddon10 = "";
	
	$FK::Version = 10;
}

function FK_RegisterRTBPrefs()
{
	RTB_registerPref("Rounds per track (-1 disables)",	"Fastkarts - Rounds",	"$Pref::Server::FASTKarts::RoundLimit",		"int -1 9999",	"GameMode_Fastkarts",	6,		false,	false,	false);
	RTB_registerPref("Allow Normal round type",			"Fastkarts - Rounds",	"$Pref::Server::FASTKarts::NormalRounds",	"bool",			"GameMode_Fastkarts",	true,	false,	false,	false);
	RTB_registerPref("Allow Rocket round type",			"Fastkarts - Rounds",	"$Pref::Server::FASTKarts::RocketRounds",	"bool",			"GameMode_Fastkarts",	false,	false,	false,	false);
	RTB_registerPref("Allow Bouncy round type",			"Fastkarts - Rounds",	"$Pref::Server::FASTKarts::BouncyRounds",	"bool",			"GameMode_Fastkarts",	false,	false,	false,	false);
	
	RTB_registerPref("Load tracks in random order",	"Fastkarts - Tracks",	"$Pref::Server::FASTKarts::RandomTracks",		"bool",									"GameMode_Fastkarts",	false,	false,	false,	false);
	RTB_registerPref("Allow player track voting",	"Fastkarts - Tracks",	"$Pref::Server::FASTKarts::EnableTrackVoting",	"list Disallow 0 Allow 1 Round_Only 2",	"GameMode_Fastkarts",	1,		false,	false,	false);
	
	RTB_registerPref("Show tip every X seconds (-1 disables)",	"Fastkarts - Tips",	"$Pref::Server::FASTKarts::TipSeconds",	"int -1 99999",	"GameMode_Fastkarts",	60,	false,	false,	false);
	
	RTB_registerPref("Enable achievements system",							"Fastkarts - Gameplay",	"$Pref::Server::FASTKarts::Achievements",		"bool",			"GameMode_Fastkarts",	true,	false,	false,	false);
	RTB_registerPref("Enable crumble death effect",							"Fastkarts - Gameplay",	"$Pref::Server::FASTKarts::CrumbleDeath",		"bool",			"GameMode_Fastkarts",	true,	false,	false,	false);
	RTB_registerPref("Enable PGDie death effects",							"Fastkarts - Gameplay",	"$Pref::Server::FASTKarts::PGDieEffects",		"bool",			"GameMode_Fastkarts",	true,	false,	false,	false);
	RTB_registerPref("Enable PGDie death sounds",							"Fastkarts - Gameplay",	"$Pref::Server::FASTKarts::PGDieSounds",		"bool",			"GameMode_Fastkarts",	true,	false,	false,	false);
	RTB_registerPref("Enable random death yells",							"Fastkarts - Gameplay",	"$Pref::Server::FASTKarts::RandomDeathYells",	"bool",			"GameMode_Fastkarts",	true,	false,	false,	false);
	RTB_registerPref("Allow vehicleless race completions",					"Fastkarts - Gameplay",	"$Pref::Server::FASTKarts::VehiclelessWins",	"bool",			"GameMode_Fastkarts",	false,	false,	false,	false);
	RTB_registerPref("Announce new records",								"Fastkarts - Gameplay",	"$Pref::Server::FASTKarts::AnnounceRecords",	"bool",			"GameMode_Fastkarts",	false,	false,	false,	false);
	RTB_registerPref("Show full time on race completion",					"Fastkarts - Gameplay",	"$Pref::Server::FASTKarts::ShowMilliseconds",	"bool",			"GameMode_Fastkarts",	false,	false,	false,	false);
	RTB_registerPref("Kill kartless players after X seconds (-1 disables)",	"Fastkarts - Gameplay",	"$Pref::Server::FASTKarts::NoKartKillTime",		"int -1 99999",	"GameMode_Fastkarts",	30,		false,	false,	false);
	
	RTB_registerPref("Horn Sounds",							"Fastkarts - Karts",	"$Pref::Server::FASTKarts::HornSounds",			"bool",			"GameMode_Fastkarts",	true,	false,	false,	false);
	RTB_registerPref("Horn Delay",							"Fastkarts - Karts",	"$Pref::Server::FASTKarts::HornMS",				"int 0 9999",	"GameMode_Fastkarts",	50,		false,	false,	false);
	RTB_registerPref("Engine Sounds",						"Fastkarts - Karts",	"$Pref::Server::FASTKarts::EngineSounds",		"bool",			"GameMode_Fastkarts",	true,	false,	false,	false);
	RTB_registerPref("Back and Forward leaning in karts",	"Fastkarts - Karts",	"$Pref::Server::FASTKarts::BackForwardLeaning",	"bool",			"GameMode_Fastkarts",	false,	true,	false,	false);
	RTB_registerPref("Rename SuperKarts to SpeedKarts",		"Fastkarts - Karts",	"$Pref::Server::FASTKarts::OldKartNames",		"bool",			"GameMode_Fastkarts",	false,	true,	false,	false);
	RTB_registerPref("Force default SpeedKarts",			"Fastkarts - Karts",	"$Pref::Server::FASTKarts::ForceSpeedkarts",	"bool",			"GameMode_Fastkarts",	false,	true,	false,	false);
	
	RTB_registerPref("Allow SpeedKart",						"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowSpeedKart",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart 64",					"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::Allow64",			"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart 7",					"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::Allow7",				"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart Blocko",				"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowBlocko",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart Buggy",				"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowBuggy",			"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart Classic",				"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowClassic",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart Classic GT",			"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowClassicGT",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart Formula",				"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowFormula",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart Hotrod",				"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowHotrod",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart Hyperion",			"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowHyperion",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart Jeep",				"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowJeep",			"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart LeMans",				"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowLeMans",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart Muscle",				"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowMuscle",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart Vintage",				"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowVintage",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart Hover",				"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowHover",			"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart Original",			"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowOriginal",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	RTB_registerPref("Allow SpeedKart Default",				"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowDefault",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	if($Pref::Server::FASTKarts::OldKartNames)
	{
		RTB_registerPref("Allow SpeedKart II",				"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowSuperKart",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
		RTB_registerPref("Allow SpeedKart ATV",				"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowSuperATV",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
		RTB_registerPref("Allow SpeedKart Hover II",		"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowSuperHover",	"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
		RTB_registerPref("Allow SpeedKart Jetski",			"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowSuperJetski",	"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
		RTB_registerPref("Allow SpeedKart Plane",			"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowSuperPlane",	"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	}
	else
	{
		RTB_registerPref("Allow SuperKart",					"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowSuperKart",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
		RTB_registerPref("Allow SuperKart ATV",				"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowSuperATV",		"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
		RTB_registerPref("Allow SuperKart Hover",			"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowSuperHover",	"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
		RTB_registerPref("Allow SuperKart Jetski",			"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowSuperJetski",	"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
		RTB_registerPref("Allow SuperKart Plane",			"Fastkarts - Allowed Karts",	"$Pref::Server::FASTKarts::AllowSuperPlane",	"bool",			"GameMode_Fastkarts",	true,	true,	false,	false);
	}
	
	RTB_registerPref("Load music from Custom GameMode",	"Fastkarts - AddOns (advanced users only)",	"$Pref::Server::FASTKarts::LoadCustomMusic",	"bool",			"GameMode_Fastkarts",	false,	true,	false,	false);
	RTB_registerPref("First add-on to load",			"Fastkarts - AddOns (advanced users only)",	"$Pref::Server::FASTKarts::LoadAddon1",			"string 200",	"GameMode_Fastkarts",	"",		true,	false,	false);
	RTB_registerPref("Second add-on to load",			"Fastkarts - AddOns (advanced users only)",	"$Pref::Server::FASTKarts::LoadAddon2",			"string 200",	"GameMode_Fastkarts",	"",		true,	false,	false);
	RTB_registerPref("Third add-on to load",			"Fastkarts - AddOns (advanced users only)",	"$Pref::Server::FASTKarts::LoadAddon3",			"string 200",	"GameMode_Fastkarts",	"",		true,	false,	false);
	RTB_registerPref("Fourth add-on to load",			"Fastkarts - AddOns (advanced users only)",	"$Pref::Server::FASTKarts::LoadAddon4",			"string 200",	"GameMode_Fastkarts",	"",		true,	false,	false);
	RTB_registerPref("Fifth add-on to load",			"Fastkarts - AddOns (advanced users only)",	"$Pref::Server::FASTKarts::LoadAddon5",			"string 200",	"GameMode_Fastkarts",	"",		true,	false,	false);
	RTB_registerPref("Sixth add-on to load",			"Fastkarts - AddOns (advanced users only)",	"$Pref::Server::FASTKarts::LoadAddon6",			"string 200",	"GameMode_Fastkarts",	"",		true,	false,	false);
	RTB_registerPref("Seventh add-on to load",			"Fastkarts - AddOns (advanced users only)",	"$Pref::Server::FASTKarts::LoadAddon7",			"string 200",	"GameMode_Fastkarts",	"",		true,	false,	false);
	RTB_registerPref("Eighth add-on to load",			"Fastkarts - AddOns (advanced users only)",	"$Pref::Server::FASTKarts::LoadAddon8",			"string 200",	"GameMode_Fastkarts",	"",		true,	false,	false);
	RTB_registerPref("Ninth add-on to load",			"Fastkarts - AddOns (advanced users only)",	"$Pref::Server::FASTKarts::LoadAddon9",			"string 200",	"GameMode_Fastkarts",	"",		true,	false,	false);
	RTB_registerPref("Tenth add-on to load",			"Fastkarts - AddOns (advanced users only)",	"$Pref::Server::FASTKarts::LoadAddon10",		"string 200",	"GameMode_Fastkarts",	"",		true,	false,	false);
}

if(!$FK::Initialized)
{
	echo("Starting up Fastkarts...");
	FK_LoadPrefs();
	echo("Version: " @ $FK::Version @ " for Rebuilt");
	echo("");
	
	echo("=== Executing add-ons manually that the host might have ===");
	
	if(isFile("Add-Ons/System_ReturnToBlockland/server.cs"))
		exec("Add-Ons/System_ReturnToBlockland/server.cs");
	else
		warn("System_ReturnToBlockland was not found");
	
	if(isFile("Add-Ons/Tool_NewDuplicator/server.cs"))
		exec("Add-Ons/Tool_NewDuplicator/server.cs");
	else
		warn("Tool_NewDuplicator was not found");
	
	echo("");
	
	echo("=== Executing implemented Fastkarts add-ons ===");
	exec("./addons/main.cs");
	echo("");
	
	echo("=== Executing custom made Fastkarts add-ons ===");
	exec("./custom/main.cs");
	echo("");
}

echo("=== Executing Fastkarts core files ===");
exec("./core/main.cs");
echo("");
echo("=== Finished executing Fastkarts files ===");
echo("");

if(!$FK::Initialized)
{
	if($Pref::Server::FASTKarts::LoadCustomMusic)
	{
		echo("=== Loading music from Custom GameMode ===");
		createMusicDatablocks();
	}
	
	if($Pref::Server::FASTKarts::LoadAddon1 !$= "" && isFile("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon1 @ "/server.cs"))
	{
		echo("=== Executing add-on 1 ===");
		exec("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon1 @ "/server.cs");
	}
	
	if($Pref::Server::FASTKarts::LoadAddon2 !$= "" && isFile("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon2 @ "/server.cs"))
	{
		echo("=== Executing add-on 2 ===");
		exec("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon2 @ "/server.cs");
	}
	
	if($Pref::Server::FASTKarts::LoadAddon3 !$= "" && isFile("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon3 @ "/server.cs"))
	{
		echo("=== Executing add-on 3 ===");
		exec("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon3 @ "/server.cs");
	}
	
	if($Pref::Server::FASTKarts::LoadAddon4 !$= "" && isFile("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon4 @ "/server.cs"))
	{
		echo("=== Executing add-on 4 ===");
		exec("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon4 @ "/server.cs");
	}
	
	if($Pref::Server::FASTKarts::LoadAddon5 !$= "" && isFile("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon5 @ "/server.cs"))
	{
		echo("=== Executing add-on 5 ===");
		exec("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon5 @ "/server.cs");
	}
	
	if($Pref::Server::FASTKarts::LoadAddon6 !$= "" && isFile("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon6 @ "/server.cs"))
	{
		echo("=== Executing add-on 6 ===");
		exec("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon6 @ "/server.cs");
	}
	
	if($Pref::Server::FASTKarts::LoadAddon7 !$= "" && isFile("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon7 @ "/server.cs"))
	{
		echo("=== Executing add-on 7 ===");
		exec("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon7 @ "/server.cs");
	}
	
	if($Pref::Server::FASTKarts::LoadAddon8 !$= "" && isFile("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon8 @ "/server.cs"))
	{
		echo("=== Executing add-on 8 ===");
		exec("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon8 @ "/server.cs");
	}
	
	if($Pref::Server::FASTKarts::LoadAddon9 !$= "" && isFile("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon9 @ "/server.cs"))
	{
		echo("=== Executing add-on 9 ===");
		exec("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon9 @ "/server.cs");
	}
	
	if($Pref::Server::FASTKarts::LoadAddon10 !$= "" && isFile("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon10 @ "/server.cs"))
	{
		echo("=== Executing add-on 10 ===");
		exec("Add-Ons/" @ $Pref::Server::FASTKarts::LoadAddon10 @ "/server.cs");
	}
	
	//chat emotes compatability
	if(isPackage(chatEmotesServer))
		deactivatePackage(chatEmotesServer);
	//we call peReplace in our own package if it exists
	
	echo("");
	
	//support_preferences compatatbility
	if($RTB::Hooks::ServerControl)
		FK_RegisterRTBPrefs();
	
	//$FK::Initialized = true; //GameModeInitialResetCheck does this already
	FK_Tick();
	FK_TipTick();
	FK_uiNameChanges();
}

function FK_exec()
{
	setmodpaths(getmodpaths());
	exec("Add-Ons/GameMode_Fastkarts/server.cs");
}