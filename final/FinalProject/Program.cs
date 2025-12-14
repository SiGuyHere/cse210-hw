using System;
class Program
{
    static void Main(string[] args)
    {
        //yes these were hand inputted
        Bruiser Aatrox = new Bruiser("Aatrox", "Top", "Attack", 49.21);
        Mage Ahri = new Mage("Ahri", "Mid", "Ability", 50.71);
        Assassin Akali = new Assassin("Akali", "Mid", "Attack", 49.66);
        Marksman Akshan = new Marksman("Akshan", "Bot", "Attack", 49.04);
        Tank Alistar = new Tank("Alistar", "Support", "Ability", 48.22);
        Bruiser Ambessa = new Bruiser("Ambessa", "Jungle", "Attack", 48.17);
        Tank Amumu = new Tank("Amumu", "Jungle", "Ability", 52.48);
        Mage Anivia = new Mage("Anivia", "Mid", "Ability", 50.64);
        Mage Annie = new Mage("Annie", "Mid", "Ability", 49.64);
        Marksman Aphelios = new Marksman("Aphelios", "Bot", "Attack", 49.54);
        Marksman Ashe = new Marksman("Ashe", "Bot", "Attack", 49.85);
        Mage AurelionSol = new Mage("Aurelion Sol", "Mid", "Ability", 50.59);
        Mage Aurora = new Mage("Aurora", "Mid", "Ability", 48.83);
        Mage Azir = new Mage("Azir", "Mid", "Ability", 44.79);
        Support Bard = new Support("Bard", "Support", "Ability", 50.26);
        Assassin BelVeth = new Assassin("Bel'Veth", "Jungle", "Attack", 49.6);
        Tank Blitzcrank = new Tank("Blitzcrank", "Support", "Ability", 49.22);
        Mage Brand = new Mage("Brand", "Support", "Ability", 52.16);
        Support Braum = new Support("Braum", "Support", "Ability", 50.34);
        Bruiser Briar = new Bruiser("Briar", "Top", "Attack", 53.22);
        Marksman Caitlyn = new Marksman("Caitlyn", "Bot", "Attack", 48.96);
        Bruiser Camille = new Bruiser("Camille", "Top", "Attack", 47.84);
        Mage Cassiopeia = new Mage("Cassiopeia", "Mid", "Ability", 50.16);
        Tank ChoGath = new Tank("Cho'Gath", "Top", "Ability", 49.75);
        Marksman Corki = new Marksman("Corki", "Bot", "Attack", 46.53);
        Bruiser Darius = new Bruiser("Darius", "Top", "Attack", 49.02);
        Mage Diana = new Mage("Diana", "Mid", "Ability", 51.11);
        Tank DrMundo = new Tank("Dr. Mundo", "Top", "Ability", 52.08);
        Marksman Draven = new Marksman("Draven", "Bot", "Attack", 48.61);
        Assassin Ekko = new Assassin("Ekko", "Mid", "Ability", 50.34);
        Assassin Elise = new Assassin("Elise", "Jungle", "Ability", 50.82);
        Assassin Evelynn = new Assassin("Evelynn", "Jungle", "Ability", 49.95);
        Marksman Ezreal = new Marksman("Ezreal", "Bot", "Attack", 48.11);
        Mage Fiddlesticks = new Mage("Fiddlesticks", "Jungle", "Ability", 50.88);
        Bruiser Fiora = new Bruiser("Fiora", "Top", "Attack", 49.53);
        Assassin Fizz = new Assassin("Fizz", "Mid", "Attack", 50.25);
        Tank Galio = new Tank("Galio", "Mid", "Ability", 49.35);
        Assassin Gangplank = new Assassin("Gangplank", "Top", "Attack", 48.57);
        Bruiser Garen = new Bruiser("Garen", "Top", "Attack", 51.34);
        Bruiser Gnar = new Bruiser("Gnar", "Top", "Attack", 49.07);
        Mage Gragas = new Mage("Gragas", "Jungle", "Ability", 48.15);
        Marksman Graves = new Marksman("Graves", "Jungle", "Attack", 49.33);
        Bruiser Gwen = new Bruiser("Gwen", "Top", "Ability", 48.66);
        Bruiser Hecarim = new Bruiser("Hecarim", "Jungle", "Attack", 48.39);
        Mage Heimerdinger = new Mage("Heimerdinger", "Mid", "Ability", 51.47);
        Mage Hwei = new Mage("Hwei", "Support", "Ability", 49.72);
        Bruiser Illaoi = new Bruiser("Illaoi", "Top", "Attack", 51.34);
        Bruiser Irelia = new Bruiser("Irelia", "Top", "Attack", 50.1);
        Support Ivern = new Support("Ivern", "Jungle", "Ability", 50.15);
        Support Janna = new Support("Janna", "Support", "Ability", 51.56);
        Tank JarvanIV = new Tank("Jarvan IV", "Jungle", "Ability", 50.41);
        Bruiser Jax = new Bruiser("Jax", "Top", "Attack", 50.84);
        Bruiser Jayce = new Bruiser("Jayce", "Top", "Attack", 48.32);
        Marksman Jhin = new Marksman("Jhin", "Bot", "Attack", 50.38);
        Marksman Jinx = new Marksman("Jinx", "Bot", "Attack", 50.47);
        Tank KSante = new Tank("K'Sante", "Top", "Attack", 45.51);
        Marksman KaiSa = new Marksman("Kai'Sa", "Bot", "Attack", 48.88);
        Marksman Kalista = new Marksman("Kalista", "Bot", "Attack", 46.71);
        Support Karma = new Support("Karma", "Support", "Ability", 50.39);
        Mage Karthus = new Mage("Karthus", "Mid", "Ability", 48.59);
        Assassin Kassadin = new Assassin("Kassadin", "Mid", "Ability", 50.83);
        Assassin Katarina = new Assassin("Katarina", "Mid", "Ability", 49.7);
        Bruiser Kayle = new Bruiser("Kayle", "Top", "Attack", 51.78);
        Assassin Kayn = new Assassin("Kayn", "Jungle", "Attack", 50.15);
        Mage Kennen = new Mage("Kennen", "Top", "Ability", 50.32);
        Assassin KhaZix = new Assassin("Kha'Zix", "Jungle", "Attack", 49.76);
        Marksman Kindred = new Marksman("Kindred", "Jungle", "Attack", 48.64);
        Bruiser Kled = new Bruiser("Kled", "Top", "Attack", 51.4);
        Marksman KogMaw = new Marksman("Kog'Maw", "Bot", "Attack", 50.98);
        Mage LeBlanc = new Mage("LeBlanc", "Mid", "Ability", 49.38);
        Bruiser LeeSin = new Bruiser("Lee Sin", "Jungle", "Attack", 48.4);
        Tank Leona = new Tank("Leona", "Support", "Ability", 51.05);
        Bruiser Lillia = new Bruiser("Lillia", "Jungle", "Ability", 50.87);
        Mage Lissandra = new Mage("Lissandra", "Mid", "Ability", 49.87);
        Marksman Lucian = new Marksman("Lucian", "Bot", "Attack", 48.54);
        Support Lulu = new Support("Lulu", "Support", "Ability", 49.25);
        Mage Lux = new Mage("Lux", "Support", "Ability", 50.05);
        Tank Malphite = new Tank("Malphite", "Top", "Ability", 51.72);
        Mage Malzahar = new Mage("Malzahar", "Mid", "Ability", 51.85);
        Tank Maokai = new Tank("Maokai", "Top", "Ability", 50.75);
        Assassin MasterYi = new Assassin("Master Yi", "Jungle", "Attack", 50.27);
        Support Milio = new Support("Milio", "Support", "Ability", 52.45);
        Marksman MissFortune = new Marksman("Miss Fortune", "Bot", "Attack", 52.32);
        Bruiser Mordekaiser = new Bruiser("Mordekaiser", "Top", "Attack", 51.29);
        Support Morgana = new Support("Morgana", "Support", "Ability", 51.29);
        Bruiser Naafiri = new Bruiser("Naafiri", "Jungle", "Attack", 51.14);
        Support Nami = new Support("Nami", "Support", "Ability", 52.04);
        Bruiser Nasus = new Bruiser("Nasus", "Top", "Attack", 50.4);
        Tank Nautilus = new Tank("Nautilus", "Support", "Ability", 49.03);
        Mage Neeko = new Mage("Neeko", "Mid", "Ability", 48.59);
        Bruiser Nidalee = new Bruiser("Nidalee", "Jungle", "Attack", 48.16);
        Marksman Nilah = new Marksman("Nilah", "Bot", "Attack", 52.03);
        Assassin Nocturne = new Assassin("Nocturne", "Jungle", "Attack", 50.09);
        Bruiser NunuWillump = new Bruiser("Nunu & Willump", "Jungle", "Attack", 49.67);
        Bruiser Olaf = new Bruiser("Olaf", "Jungle", "Attack", 50.76);
        Mage Orianna = new Mage("Orianna", "Mid", "Ability", 48.35);
        Tank Ornn = new Tank("Ornn", "Top", "Ability", 49.63);
        Assassin Pantheon = new Assassin("Pantheon", "Bot", "Attack", 49.03);
        Bruiser Poppy = new Bruiser("Poppy", "Top", "Ability", 50.64);
        Assassin Pyke = new Assassin("Pyke", "Support", "Ability", 48.74);
        Assassin Qiyana = new Assassin("Qiyana", "Mid", "Ability", 46.8);
        Marksman Quinn = new Marksman("Quinn", "Top", "Attack", 50.04);
        Tank Rakan = new Tank("Rakan", "Support", "Ability", 49.07);
        Tank Rammus = new Tank("Rammus", "Jungle", "Tank", 51.99);
        Bruiser RekSai = new Bruiser("Rek'Sai", "Jungle", "Attack", 49.69);
        Tank Rell = new Tank("Rell", "Support", "Ability", 49.21);
        Support Renata = new Support("Renata Glasc", "Support", "Ability", 50.23);
        Bruiser Renekton = new Bruiser("Renekton", "Top", "Attack", 49.7);
        Assassin Rengar = new Assassin("Rengar", "Jungle", "Attack", 45.82);
        Bruiser Riven = new Bruiser("Riven", "Top", "Attack", 48.61);
        Bruiser Rumble = new Bruiser("Rumble","Top", "Ability", 48.96);
        Mage Ryze = new Mage("Ryze","Mid", "Ability", 48.96);
        Marksman Samira = new Marksman("Samira", "Bot", "Attack", 49.9);
        Tank Sejuani = new Tank("Sejuani", "Jungle", "Ability", 48.89);
        Marksman Senna = new Marksman("Senna", "Bot", "Attack", 49.19);
        Support Seraphine = new Support("Seraphine", "Support", "Ability", 50.08);
        Bruiser Sett = new Bruiser("Sett", "Top", "Attack", 51.73);
        Assassin Shaco = new Assassin("Shaco", "Jungle", "Attack", 49.71);
        Bruiser Shen = new Bruiser("Shen", "Top", "Ability", 49.88);
        Bruiser Shyvana = new Bruiser("Shyvana", "Jungle", "Attack", 49.99);
        Bruiser Singed = new Bruiser("Singed", "Top", "Ability", 52.58);
        Tank Sion = new Tank("Sion", "Top", "Ability", 51.04);
        Marksman Sivir = new Marksman("Sivir", "Bot", "Attack", 50.17);
        Tank Skarner = new Tank("Skarner", "Jungle", "Attack", 44.58);
        Support Sona = new Support("Sona", "Support", "Ability", 51.67);
        Support Soraka = new Support("Soraka", "Support", "Ability", 51.42);
        Bruiser Swain = new Bruiser("Swain", "Mid", "Ability", 51.43);
        Assassin Sylas = new Assassin("Sylas", "Mid", "Ability", 49.69);
        Mage Syndra = new Mage("Syndra", "Mid", "Ability", 50.27);
        Tank TahmKench = new Tank("Tahm Kench", "Support", "Ability", 49.27);
        Mage Taliyah = new Mage("Taliyah", "Mid", "Ability", 47.99);
        Assassin Talon = new Assassin("Talon", "Mid", "Attack", 49.71);
        Tank Taric = new Tank("Taric", "Support", "Ability", 51.69);
        Mage Teemo = new Mage("Teemo", "Top", "Attack", 51.82);
        Tank Thresh = new Tank("Thresh", "Support", "Ability", 49.75);
        Marksman Tristana = new Marksman("Tristana", "Bot", "Attack", 49.38);
        Bruiser Trundle = new Bruiser("Trundle", "Top", "Attack", 49.99);
        Bruiser Tryndamere = new Bruiser("Tryndamere", "Top", "Attack", 49.17);
        Marksman TwistedFate = new Marksman("Twisted Fate", "Mid", "Ability", 49.15);
        Marksman Twitch = new Marksman("Twitch", "Bot", "Attack", 48.84);
        Bruiser Udyr = new Bruiser("Udyr", "Jungle", "Attack", 49.08);
        Bruiser Urgot = new Bruiser("Urgot", "Top", "Attack", 51.74);
        Assassin Varus = new Assassin("Varus", "Bot", "Attack", 46.88);
        Marksman Vayne = new Marksman("Vayne", "Bot", "Attack", 51.08);
        Mage Veigar = new Mage("Veigar", "Mid", "Ability", 51.32);
        Mage Velkoz = new Mage("Vel'Koz", "Mid", "Ability", 51.69);
        Mage Vex = new Mage("Vex", "Mid", "Ability", 50.66);
        Bruiser Vi = new Bruiser("Vi", "Jungle", "Attack", 58.26);
        Bruiser Viego = new Bruiser("Viego", "Jungle", "Attack", 50.73);
        Mage Viktor = new Mage("Viktor", "Mid", "Ability", 50.29);
        Bruiser Vladimir = new Bruiser("Vladimir", "Top", "Ability", 49.55);
        Bruiser Volibear = new Bruiser("Volibear", "Top", "Attack", 50.0);
        Assassin Warwick = new Assassin("Warwick", "Jungle", "Attack", 51.95);
        Bruiser Wukong = new Bruiser("Wukong", "Top", "Attack", 50.62);
        Marksman Xayah = new Marksman("Xayah", "Bot", "Attack", 49.6);
        Mage Xerath = new Mage("Xerath", "Mid", "Ability", 51.11);
        Bruiser XinZhao = new Bruiser("Xin Zhao", "Jungle", "Attack", 49.77);
        Assassin Yasuo = new Assassin("Yasuo", "Mid", "Attack", 49.71);
        Bruiser Yone = new Bruiser("Yone", "Mid", "Attack", 48.59);
        Bruiser Yorick = new Bruiser("Yorick", "Top", "Attack", 51.67);
        Support Yuumi = new Support("Yuumi", "Support", "Ability", 46.56);
        Bruiser Zac = new Bruiser("Zac", "Jungle", "Ability", 50.22);
        Bruiser Zaahen = new Bruiser("Zaahen", "Top", "Attack", 49.91);
        Assassin Zed = new Assassin("Zed", "Mid", "Attack", 48.38);
        Mage Ziggs = new Mage("Ziggs", "Mid", "Ability", 50.83);
        Support Zilean = new Support("Zilean", "Support", "Ability", 51.21);
        Mage Zoe = new Mage("Zoe", "Mid", "Ability", 48.42);
        Mage Zyra = new Mage("Zyra", "Support", "Ability", 51.97);
        Aurora.Counters.AddRange(["Fizz", "Kassadin", "LeBlanc"]);
        Ambessa.Counters.AddRange(["Malphite", "Fiora", "Quinn"]);
        Elise.Counters.AddRange(["Olaf", "Trundle", "Hecarim"]);
        Evelynn.Counters.AddRange(["Malzahar", "Lissandra", "Galio"]);
        Ezreal.Counters.AddRange(["Blitzcrank", "Leona", "Alistar"]);
        Fiddlesticks.Counters.AddRange(["LeeSin", "Olaf", "Trundle"]);
        Zaahen.Counters.AddRange(["Malphite", "Fiora", "Quinn"]);
        Aatrox.Counters.AddRange(["Malphite", "Fizz", "Vayne" ]);
        Ahri.Counters.AddRange(["Kassadin", "Galio", "Yasuo"]);
        Akali.Counters.AddRange(["Galio", "Kassadin", "Annie"]);
        Akshan.Counters.AddRange(["Draven", "Vayne", "Rell"]);
        Alistar.Counters.AddRange(["Vayne", "Ezreal", "Morgana"]);
        Amumu.Counters.AddRange(["Viego", "Jax", "Warwick"]);
        Anivia.Counters.AddRange(["Zed", "Fizz", "Yasuo"]);
        Annie.Counters.AddRange(["Fizz", "LeBlanc", "Kassadin"]);
        Aphelios.Counters.AddRange(["Leona", "Blitzcrank", "Thresh"]);
        Ashe.Counters.AddRange(["Olaf", "Draven", "Vayne"]);
        AurelionSol.Counters.AddRange(["Fizz", "Kassadin", "Yasuo"]);
        Azir.Counters.AddRange(["Kassadin", "Zed", "LeBlanc"]);
        Bard.Counters.AddRange(["Blitzcrank", "Pyke", "Leona"]);
        BelVeth.Counters.AddRange(["Viego", "Hecarim", "Olaf"]);
        Blitzcrank.Counters.AddRange(["Morgana", "Ezreal", "Thresh"]);
        Brand.Counters.AddRange(["LeBlanc", "Fizz", "Zed"]);
        Braum.Counters.AddRange(["Blitzcrank", "Pyke", "Senna"]);
        Briar.Counters.AddRange(["Camille", "Viego", "Jax"]);
        Caitlyn.Counters.AddRange(["Draven", "Quinn", "Lucian"]);
        Camille.Counters.AddRange(["Malphite", "Fiora", "Shen"]);
        Cassiopeia.Counters.AddRange(["Kassadin", "Fizz", "LeBlanc"]);
        ChoGath.Counters.AddRange(["Teemo", "Quinn", "Fiora"]);
        Corki.Counters.AddRange(["Caitlyn", "Draven", "Vayne"]);
        Darius.Counters.AddRange(["Fiora", "Teemo", "Quinn"]);
        Diana.Counters.AddRange(["Kassadin", "Lissandra", "Galio"]);
        DrMundo.Counters.AddRange(["Kennen", "Fiora", "Vayne"]);
        Draven.Counters.AddRange(["Quinn", "Blitzcrank", "Leona"]);
        Ekko.Counters.AddRange(["Lissandra", "Kassadin", "Galio"]);
        Fiora.Counters.AddRange(["Quinn", "Malphite", "Teemo"]);
        Fizz.Counters.AddRange(["Malzahar", "Lissandra", "Galio"]);
        Galio.Counters.AddRange(["Yasuo", "Kassadin", "Vladimir"]);
        Gangplank.Counters.AddRange(["Darius", "Fiora", "Camille"]);
        Garen.Counters.AddRange(["Teemo", "Quinn", "Fiora"]);
        Gnar.Counters.AddRange(["Darius", "Camille", "Riven"]);
        Gragas.Counters.AddRange(["Warwick", "Olaf", "Kindred"]);
        Graves.Counters.AddRange(["Viego", "Olaf", "Draven"]);
        Gwen.Counters.AddRange(["Fiora", "Kassadin", "Malphite"]);
        Hecarim.Counters.AddRange(["Morgana", "Lissandra", "Vayne"]);
        Heimerdinger.Counters.AddRange(["Zed", "Fizz", "LeBlanc"]);
        Hwei.Counters.AddRange(["Pyke", "Leona", "Blitzcrank"]);
        Illaoi.Counters.AddRange(["Teemo", "Quinn", "Fiora"]);
        Irelia.Counters.AddRange(["Malphite", "Quinn", "Teemo"]);
        Ivern.Counters.AddRange(["Amumu", "Olaf", "Hecarim"]);
        Janna.Counters.AddRange(["Blitzcrank", "Leona", "Pyke"]);
        JarvanIV.Counters.AddRange(["Trundle", "Kennen", "Viego"]);
        Jax.Counters.AddRange(["Teemo", "Quinn", "Malphite"]);
        Jayce.Counters.AddRange(["Malphite", "Fiora", "Riven"]);
        Jhin.Counters.AddRange(["Blitzcrank", "Leona", "Thresh"]);
        Jinx.Counters.AddRange(["Leona", "Blitzcrank", "Alistar"]);
        KSante.Counters.AddRange(["Fiora", "Vayne", "Quinn"]);
        KaiSa.Counters.AddRange(["Leona", "Blitzcrank", "Thresh"]);
        Kalista.Counters.AddRange(["Alistar", "Leona", "Braum"]);
        Karma.Counters.AddRange(["Zyra", "Morgana", "Brand"]);
        Karthus.Counters.AddRange(["Zed", "Fizz", "Kassadin"]);
        Kassadin.Counters.AddRange(["Galio", "Lissandra", "Malzahar"]);
        Katarina.Counters.AddRange(["Lissandra", "Kassadin", "Galio"]);
        Kayle.Counters.AddRange(["Malphite", "Fiora", "Vayne"]);
        Kayn.Counters.AddRange(["Jax", "Malphite", "Trundle"]);
        Kennen.Counters.AddRange(["Malphite", "Darius", "Fiora"]);
        KhaZix.Counters.AddRange(["Amumu", "Olaf", "Viego"]);
        Kindred.Counters.AddRange(["Olaf", "Hecarim", "Warwick"]);
        Kled.Counters.AddRange(["Teemo", "Fiora", "Quinn"]);
        KogMaw.Counters.AddRange(["Leona", "Blitzcrank", "Alistar"]);
        LeBlanc.Counters.AddRange(["Kassadin", "Zed", "Galio"]);
        LeeSin.Counters.AddRange(["Trundle", "Malphite", "Jax"]);
        Leona.Counters.AddRange(["Morgana", "Janna", "Blitzcrank"]);
        Lillia.Counters.AddRange(["Olaf", "Hecarim", "Trundle"]);
        Lissandra.Counters.AddRange(["Zed", "Fizz", "Kassadin"]);
        Lucian.Counters.AddRange(["Blitzcrank", "Leona", "Thresh"]);
        Lulu.Counters.AddRange(["Blitzcrank", "Leona", "Alistar"]);
        Lux.Counters.AddRange(["Yasuo", "Zed", "Kassadin"]);
        Malphite.Counters.AddRange(["Fiora", "Vayne", "Quinn"]);
        Malzahar.Counters.AddRange(["Kassadin", "Fizz", "Lissandra"]);
        Maokai.Counters.AddRange(["Viego", "Olaf", "Hecarim"]);
        MasterYi.Counters.AddRange(["Malzahar", "Lissandra", "Trundle"]);
        Milio.Counters.AddRange(["Blitzcrank", "Leona", "Pyke"]);
        MissFortune.Counters.AddRange(["Leona", "Alistar", "Thresh"]);
        Mordekaiser.Counters.AddRange(["Vayne", "Kayle", "Teemo"]);
        Morgana.Counters.AddRange(["Blitzcrank", "Leona", "Alistar"]);
        Naafiri.Counters.AddRange(["Olaf", "Viego", "Kayn"]);
        Nami.Counters.AddRange(["Blitzcrank", "Leona", "Pyke"]);
        Nasus.Counters.AddRange(["Teemo", "Vayne", "Quinn"]);
        Nautilus.Counters.AddRange(["Vayne", "Caitlyn", "Draven"]);
        Neeko.Counters.AddRange(["LeBlanc", "Fizz", "Kassadin"]);
        Nidalee.Counters.AddRange(["Olaf", "Kennen", "Hecarim"]);
        Nilah.Counters.AddRange(["Leona", "Blitzcrank", "Alistar"]);
        Nocturne.Counters.AddRange(["Morgana", "Janna", "Lulu"]);
        NunuWillump.Counters.AddRange(["Olaf", "Hecarim", "Trundle"]);
        Olaf.Counters.AddRange(["Malphite", "Fiora", "Quinn"]);
        Orianna.Counters.AddRange(["Zed", "Fizz", "LeBlanc"]);
        Ornn.Counters.AddRange(["Fiora", "Camille", "Teemo"]);
        Pantheon.Counters.AddRange(["Malphite", "Quinn", "Fiora"]);
        Poppy.Counters.AddRange(["Fiora", "Camille", "Quinn"]);
        Pyke.Counters.AddRange(["Blitzcrank", "Leona", "Thresh"]);
        Qiyana.Counters.AddRange(["Malphite", "Lissandra", "Galio"]);
        Quinn.Counters.AddRange(["Malphite", "Fiora", "Teemo"]);
        Rakan.Counters.AddRange(["Blitzcrank", "Leona", "Alistar"]);
        Rammus.Counters.AddRange(["Teemo", "Kennen", "Fiora"]);
        RekSai.Counters.AddRange(["Olaf", "Warwick", "Viego"]);
        Rell.Counters.AddRange(["Leona", "Blitzcrank", "Alistar"]);
        Renata.Counters.AddRange(["Blitzcrank", "Leona", "Pyke"]);
        Renekton.Counters.AddRange(["Fiora", "Malphite", "Quinn"]);
        Rengar.Counters.AddRange(["Malzahar", "Lissandra", "Olaf"]);
        Riven.Counters.AddRange(["Malphite", "Quinn", "Fiora"]);
        Rumble.Counters.AddRange(["Fizz", "Kassadin", "LeBlanc"]);
        Ryze.Counters.AddRange(["Fizz", "Kassadin", "LeBlanc"]);
        Samira.Counters.AddRange(["Leona", "Blitzcrank", "Alistar"]);
        Sejuani.Counters.AddRange(["Olaf", "Trundle", "Viego"]);
        Senna.Counters.AddRange(["Leona", "Blitzcrank", "Alistar"]);
        Seraphine.Counters.AddRange(["LeBlanc", "Fizz", "Zed"]);
        Sett.Counters.AddRange(["Fiora", "Malphite", "Quinn"]);
        Shaco.Counters.AddRange(["Olaf", "Trundle", "Kassadin"]);
        Shen.Counters.AddRange(["Fiora", "Malphite", "Camille"]);
        Shyvana.Counters.AddRange(["Olaf", "Trundle", "Hecarim"]);
        Singed.Counters.AddRange(["Teemo", "Quinn", "Fiora"]);
        Sion.Counters.AddRange(["Fiora", "Teemo", "Quinn"]);
        Sivir.Counters.AddRange(["Leona", "Blitzcrank", "Alistar"]);
        Skarner.Counters.AddRange(["Olaf", "Trundle", "Hecarim"]);
        Sona.Counters.AddRange(["Blitzcrank", "Leona", "Pyke"]);
        Soraka.Counters.AddRange(["Blitzcrank", "Leona", "Alistar"]);
        Swain.Counters.AddRange(["Zed", "Fizz", "Kassadin"]);
        Sylas.Counters.AddRange(["Malphite", "Fiora", "Quinn"]);
        Syndra.Counters.AddRange(["Fizz", "Kassadin", "LeBlanc"]);
        TahmKench.Counters.AddRange(["Blitzcrank", "Leona", "Pyke"]);
        Taliyah.Counters.AddRange(["Fizz", "Kassadin", "LeBlanc"]);
        Talon.Counters.AddRange(["Malphite", "Lissandra", "Galio"]);
        Taric.Counters.AddRange(["Blitzcrank", "Leona", "Alistar"]);
        Teemo.Counters.AddRange(["Olaf", "Hecarim", "Fiora"]);
        Thresh.Counters.AddRange(["Blitzcrank", "Leona", "Alistar"]);
        Tristana.Counters.AddRange(["Leona", "Blitzcrank", "Alistar"]);
        Trundle.Counters.AddRange(["Fiora", "Malphite", "Quinn"]);
        Tryndamere.Counters.AddRange(["Malphite", "Poppy", "Fiora"]);
        TwistedFate.Counters.AddRange(["Fizz", "Kassadin", "LeBlanc"]);
        Twitch.Counters.AddRange(["Leona", "Blitzcrank", "Alistar"]);
        Udyr.Counters.AddRange(["Olaf", "Trundle", "Hecarim"]);
        Urgot.Counters.AddRange(["Fiora", "Quinn", "Malphite"]);
        Varus.Counters.AddRange(["Leona", "Blitzcrank", "Alistar"]);
        Vayne.Counters.AddRange(["Draven", "Quinn", "Leona"]);
        Veigar.Counters.AddRange(["Fizz", "Kassadin", "LeBlanc"]);
        Velkoz.Counters.AddRange(["Fizz", "Kassadin", "Zed"]);
        Vex.Counters.AddRange(["Fizz", "Kassadin", "LeBlanc"]);
        Vi.Counters.AddRange(["Malphite", "Trundle", "Jax"]);
        Viego.Counters.AddRange(["Olaf", "Trundle", "Hecarim"]);
        Viktor.Counters.AddRange(["Fizz", "Kassadin", "LeBlanc"]);
        Vladimir.Counters.AddRange(["Malphite", "Fiora", "Quinn"]);
        Volibear.Counters.AddRange(["Olaf", "Trundle", "Hecarim"]);
        Warwick.Counters.AddRange(["Trundle", "Olaf", "Hecarim"]);
        Wukong.Counters.AddRange(["Malphite", "Teemo", "Fiora"]);
        Xayah.Counters.AddRange(["Leona", "Blitzcrank", "Alistar"]);
        Xerath.Counters.AddRange(["Zed", "Fizz", "LeBlanc"]);
        XinZhao.Counters.AddRange(["Trundle", "Olaf", "Hecarim"]);
        Yasuo.Counters.AddRange(["Malphite", "Lissandra", "Galio"]);
        Yone.Counters.AddRange(["Malphite", "Quinn", "Fiora"]);
        Yorick.Counters.AddRange(["Teemo", "Quinn", "Fiora"]);
        Yuumi.Counters.AddRange(["Blitzcrank", "Leona", "Alistar"]);
        Zac.Counters.AddRange(["Olaf", "Trundle", "Hecarim"]);
        Zed.Counters.AddRange(["Galio", "Kassadin", "Lissandra"]);
        Ziggs.Counters.AddRange(["Fizz", "Kassadin", "LeBlanc"]);
        Zilean.Counters.AddRange(["Blitzcrank", "Leona", "Pyke"]);
        Zoe.Counters.AddRange(["Fizz", "Kassadin", "LeBlanc"]);
        Zyra.Counters.AddRange(["Blitzcrank", "Leona", "Alistar"]);


        DraftAdvisor advisor = new DraftAdvisor();

        Console.WriteLine("League of Legends Draft Helper\n");

        string[] lanes = ["Top", "Mid", "Bot", "Jungle", "Support"];

        for (int i = 0; i < 10; i++) 
        {
            string picker = (i % 2 == 0) ? "Your team" : "Enemy";
            Console.WriteLine($"\n{picker}'s turn to pick a champion:");

            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Write("Champion name: ");
                string input = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                Champion champ = Champion.FindChampionByName(input);
                if (champ == null)
                {
                    Console.WriteLine("Champion not found. Try again.");
                    continue;
                }

                bool alreadyPicked = advisor.TeamPicks.Contains(champ) || advisor.EnemyPicks.Contains(champ);
                if (alreadyPicked)
                {
                    Console.WriteLine("Champion already picked. Choose another.");
                    continue;
                }

                if (i % 2 == 0)
                {
                    advisor.TeamPicks.Add(champ);
                }
                else
                {
                    advisor.EnemyPicks.Add(champ);
                }

                Console.WriteLine($"{champ} added to {picker}.\n");
                keepGoing = false;
            }

            if (i % 2 != 0)
            {
                Console.WriteLine("Top 5 suggestions for unfilled lanes:");
                bool anySuggestions = false;
                foreach (string lane in lanes)
                {
                    bool laneFilled = advisor.TeamPicks.Any(pick => pick.Lane.Equals(lane, StringComparison.OrdinalIgnoreCase));
                    if (!laneFilled)
                    {
                        List<Champion> topChamps = advisor.SuggestTopChampions(lane);
                        if (topChamps.Count > 0)
                        {
                            anySuggestions = true;
                            Console.WriteLine($"\n{lane}:");
                            for (int j = 0; j < topChamps.Count; j++)
                            {
                                Console.WriteLine($"{j + 1}. {topChamps[j]}");
                            }
                        }
                    }
                }
                if (!anySuggestions)
                {
                    Console.WriteLine("All lanes filled or no available champions.");
                }
            }
        }

    Console.WriteLine("\nDraft complete!");
    }
}
