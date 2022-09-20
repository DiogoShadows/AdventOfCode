﻿using AdventOfCode2021.Days;

namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> lista = new List<List<int>>();

            for(int i = 0; i < INPUT.Length; i++)
            {
                var linha = new List<int>();
                foreach(var caracter in INPUT[i])
                {
                    linha.Add(Int32.Parse(caracter.ToString()));
                }

                lista.Add(linha);
            }

            Console.WriteLine(Day_9.PartTwo(lista));
        }

        public static string[] INPUT = new string[] { "7654345689435693459878789998765434578897598965987654567987654532367891034984323456898764323467899987", "9987466795424989998765678999994323456789997894598943678998543101456789129865212567999765434589989976", "9876578976512976899654569899889437597999876783439895789987654212347999939874101459789899545679878964", "6988989987109865698743456789679545989998965432129789998698795345789979896543212345678998957989567893", "4699798998998754987654568894578959876987896549098659897549987456898856799654323656789987898997678932", "3489657899876543298778679933489798765976989698987545789932196567987645678975834569899986789998799321", "2678999912998432109888789212345679654865678987658734896893987689875436789987765699949875678999895434", "1249878943986554236999899101234598743254568896543210345789298999876648995899876789439764567899996595", "0198767894997669345678998432545696432123656799655321234689109998987756894799987899998643446789989989", "2398758989899798956989996548756987632012345678967434545678919897898767953688998999876532334678979875", "3987649876789987899899987667867975432123456789978945656789998776429879542567899678987710124589569954", "4698659765567896458789998778978986943245667999989976789899897683212989653456894599799899295697698743", "5798798654478987324567899889989998754356778978999987999998796543101298764567895789521998989789987656", "7899996432379998999689999995798999865467889566679898999897689956242349985698999896432987978999898787", "8943987621068989878999998764567899878688993454598769098754567894369467899989998976564996767898789898", "9432197543459878567899876543457976999789432123459853129843456789498998998978987897679765456987653939", "6543987654598767378799987895569765799897693344598764598932458899987899997565476989798654348995462124", "7654698767987656235689599987678934677998989495689895987643567949876789986455365678999985459976321035", "9865679878996543124679445698989323456789878989789986798769679129865699875321234567894976567997532123", "4987897989987674234569326579993212967898767878990298909998989234984789765410165678943998778989644365", "3498976899999865675678912456789909898987657567892349212397698949875679879643276789999879899678955466", "2349875678989876789789109578999898799878546458999998993986566799998789998784356999989964934567966567", "3498764889976987899899298989439765698767423349998876789975435689109994349899867899978943423979897779", "4989986798765498945978987896598674987656101238987564998654320457929893234999878998767952019898799989", "9878998999896329234567896989986543198743234567896432349765932345998789123997989876545694199767659899", "8767899899985410123459945678998432019654455698998543559898743456789678999876693997987789987754546789", "9658998789876522934568934567899543198765568899789654678987654767894589989995432398998899876543235678", "8436789678987699895678923456987654569878779912698765789498765688923478966987621239549987987532123467", "7545679552398989789789501568898765678989889103589899895379978799212367954399543567932495398971012346", "8658795431239975678995413456789878789999993214678965921267989894324456891298654698921249219864124587", "9767896532399864567895324567898989899898765329999954310347999999936967910129765989910198996543234679", "9878976543987653456789435689987791999799976998787895498656898998897898923239899867891397987654356789", "1989988659875472369898956789976510197688989867646979999777987987789999439356987656789986798765577899", "0997699767964321288997897898765439298567997654434569899989876545679986548498999845679765649986788928", "9896549899875432467986899999878998975459877843212345799993988766889999867567987635678984334987999647", "6679432987989876578965789999989987894355965432101234678932399877897891997679996424569832126898999656", "4598949876895987689874677988991096543234986543212345699993999998966890989798987534998721034679898767", "2456798965684598799863456677893497864565799987654586789989898999245699976987899549876543545889659898", "3567987754323459896542107556794998965676798998767678999977767891027988545276989656987954656789543959", "4679876543213456987654212346789899976787997899898789109866456789129876432165678967898766897899932345", "8789765432104587899765423487996768987899976789949899398654345695434975321013459878999977898999891567", "9899876543312345678986567899545656799999875345932998999765236789549875434324578999899988939998789789", "9999998754323478989999878976632445921098763267893976989872123497678987896455689987689999924996579999", "9998959766434567899899989654321235892129654346999895678964334569799698989996789876568976899876468999", "8786549877576778978789997654210126789239765656898764389895445678989549876789899965479765398765347898", "7665433989699989355678999765331234895397978967999865456789578989678939765689999874366972129986656987", "6543212399998994244598899865473346976986989879888976768897699594567998754578899983245983456998968976", "7432101298787893123456789876654957989765492989767597899998895423479899532356789654159899869899899765", "8653232399656799254667999987765798999854301997654398943219974310298764310134798969299789998789789654", "9654343987545978965788998999876899899943219876543129894398765421349899743234567898987678977678699776", "9965556895438767897899877698987998789854345987654436789999886543757987654359678987677549765434578988", "9878667954324556898998766567898987698765456998766545689899998765698998769878989976565439854523456899", "9989899843212346799998843456789875439896567899898659789789899878789439878989998765432129953212367899", "8898987642101237899987642368999654323987678956959767893579788989899323989997899876643298763101234989", "7657898653212345789876543599998875404598799545349878932498656999998939999996853987854789965312345678", "7545679767435656898987665789987654212689895431234989321987645789987898989875432398765679876423656789", "6436569976545787957898976789398786323789996732345795439998534598765997678954321289876789987565767892", "4325467987656798946989987895259865434699987876556789598765423699989876567895410178989898798679878921", "5212345998787899234976599964345986545699898997798899989986534789999987679976551269899987689989989630", "7434459879998910129895498765456987656789649098999999978987649899988998895987643456789893567899997541", "6545669867899432398789329987667998767898932129890198867698756789976899993198759567898762498999876432", "7656779756789546987677934598899879878967943235791987656569987899765656689019998998987651349899998543", "8987998645878959876546899679976567989456899999899876743456798987654334568999876789876540256789798656", "9899875434868998765435678998765459894345798878998765332367899876543223456789125679865431247895679787", "8789994323245999865324789987654398743234987656999873210178978987674105689891013789976562348934567998", "7679986710139899874312398998543219654345697745898765421234568998765216789932123893297678467923456789", "4549875421239789965423987897652109865456986435679989432346879987654347898543434895398799578901969894", "3234987542398679896749876996543323976789875424598998543456896999878657897654545697569987679999898943", "4845986543987545789898965989654435987898764312357897654568945798988789998765756789679899789989787891", "5657987654597634899987654879776846798929976457478998875679034597699891239879867898798776999875676789", "6789098765698745679876543467987957909101987868999899989989129986578994345989978959898665698654345789", "7892139978789856789987832378998969219223798979498787698999998775457989656994989545998543987543259891", "8943234989899867999984321267899878998954689989599678567899899653376878979873293236997632399654348932", "9654545799987978999876546345976989987898796799987543456998798732124567898764139099889321098766567893", "8766656898976799789989658466795699996789895898765432349997654321034678987653298987678992129897678989", "9878789957895434679898769577894569865699996799986651298989765432123799899764987843567789234998799978", "5989992346789523898789989989923498654568989987999879987878998643334896789999876532345678945679894667", "4597641256897654679678999893212987643479678986899998876569897654545945998789976521234589896789923458", "3696532368998999798989898789309865432123569865789987642456789875776799897679985430145698798899765679", "1987893567899878997898765679998979545844598754899999431368899976987898654456976321256798689949876789", "2998954688999767986789654569867498956755987643459876420235789987898998543339865452345897578939997893", "9879767799678955675696543398754356969896798732198765431236798998969987652123986566456976489998989912", "9769899896599843434989432109969197897987899841019876578387897899659896543235697677867895357987878923", "8754957989987651029878953299897989986498998843123998999498956976545798654345698989998943238996467899", "9843245678998743198969954986775878975349987654367899889999549897434899765679789598899652129994359998", "9990156789129858987657899975764567893234999776458998769893236789323999876789892456789543298783234987", "9983245693012967989545798754523456789349877976567987656789945678939889999897941378997665987672135695", "8765456892149879878434598743212377897598765987879876745787896789997767567976532399998987998531046794", "9878967893234998767323569654323458998989854398989985436456789899986643456989544589989898987632397985", "3989878954346789853214598766535567899878969129799999321367899989875432347898765678976789998784459876", "2394989765457899868325799899678678998767998945679898990258999876997655456789876789875789999765678989", "1923499986598999879876892998789899987654567896998767889346789964349876567995987897654567899876789198", "9894678997699998989997921469999999876723456789876656778956799878459998678964398959865978999997894236", "8789789598789987898999892391018899865212347899765544567897892986578969799973129949877899987698976545", "5678994329899876757899789989127789954324456987654323798998910299989359899995439899989912976559987656", "4567893210998765645998678978935699875434597899766214789989321998993234989876599798999101965445999767", "3456789321987653239876545456896789986575689959874325678978949887892123578989987687898929876323799898", "1078896434596542198765432345789894987676793234965456789568999756789012689999876576787898765417678919", "2186989549985421049985321236893913498989890123496567893478987645678923478921987324896799954324589101", "3245678998765434239876434345932101679999954334987678912456798726799434567892393212345789875435678923" };
    }

}