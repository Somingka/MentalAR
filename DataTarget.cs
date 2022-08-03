using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class DataTarget : MonoBehaviour
{
    public Transform TextTargetName;
    public Transform TextDescription;
    public Transform ButtonAction;
    public Transform PanelDescription;

    public AudioSource soundTarget;
    public AudioClip clipTarget;

    // Use this for initialization
    void Start()
    {
        //add Audio Source as new game object component
        soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vuforia.StateManager sm = TrackerManager.Instance.GetStateManager();
        IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

        foreach (TrackableBehaviour tb in tbs)
        {
            string name = tb.TrackableName;
            ImageTarget it = tb.Trackable as ImageTarget;
            Vector2 size = it.GetSize();

            Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);


            TextTargetName.GetComponent<Text>().text = name;
            ButtonAction.gameObject.SetActive(true);
            TextDescription.gameObject.SetActive(true);
            PanelDescription.gameObject.SetActive(true);

            if (name == "Bipolar")
            {
                TextDescription.GetComponent<Text>().text =
                    "Bipolar merupakan masalah mental yang membuat pengidapnya mengalami perubahan emosi yang drastis dan berulang pada waktu yang singkat. kadang pasien merasa sangat gembira, mudah terganggu atau bersemangat. ini disebut dengan episode manik.Di lain waktu pasien mungkin merasa sedih, acuh, atau putus asa.ini disebut episode depresif. Orang yang mengidap penyakit ini juga bisa juga memiliki gejala manik dan depresif bersamaan yang biasanya disebut episode campuran." + "\n" + "\n" +
                    "Seiring perubahan suasana hati, bipolar menyebabkan perubahan perilaku, energi, dan tingkat aktivitas sesuai episode yang dialami." + "\n" + "\n" +
                    "Gejala:" + "\n" +
                    "episode harus berlangsung minimal 1 minggu dan mengacaukan aktivitas yang biasanya dilakukan" + "\n" + "\n" +
                    "Episode manik" + "\n" +
                    "- Merasa bersemangat atau gembira" + "\n" +
                    "- Merasa gelisah atau tegang" + "\n" +
                    "- Mudah tergganggu" + "\n" +
                    "- Kurang tidur" + "\n" + "\n" +
                    "Episode depresi" + "\n" +
                    "- merasa sedih atau putus asa" + "\n" +
                    "- Merasa kesepian atau mengisolasi diri" + "\n" +
                    "- Terlalu banyak makan dan tidur" + "\n" +
                    "- Kurang minat dalam aktivitas yang biasa dilakukan" + "\n" + "\n" +
                    "Penyebab dari gangguan bipolar belum diketahui. Namun ada beberapa faktor yang mungkin memiliki peran dalam gangguan ini, seperti genetik, struktur dan fungsi otak,serta pengaruh lingkungan." + "\n" +
                    "Bipolar disorder bisa dirawat dengan:" + "\n" +
                    "- Obat - obatan" + "\n" +
                    "- Psychoterapy";
            }

            if (name == "Skizofrenia")
            {
                TextDescription.GetComponent<Text>().text = "Skizofrenia adalah suatu deskripsi sindrom dengan penyebab yang belum diketahui dan perjalanan penyakit yang tidak kronis. Pada umumnya ditandai oleh penyimpangan fungsi dasar dan karakteristik dari pikiran dan persepsi, serta mood yang tidak wajar." + "\n" + "\n" +
                    "Gejala:" + "\n" +
                    "Biasanya gejala berlangsung selama kurun waktu satu bulan atau lebih dan ada perubahan dari perilaku" + "\n" + "\n" +
                    "Gejala skizofrenia terbagi menjadi dua kategori yaitu:" + "\n" +
                    "Gejala Positif" + "\n" +
                    "- Halusinasi" + "\n" +
                    "- Delusi" + "\n" +
                    "- Kekacauan dalam berpikir dan berperilaku" + "\n" + "\n" +
                    "Gejala negatif" + "\n" +
                    "- Sulit merasa senang atau puas" + "\n" +
                    "- Mengisolasi diri" + "\n" +
                    "- Tidak peduli dengan penampilan dan kebersihan diri" + "\n" + "\n" +
                    "Penyebab dari gangguan ini belum dikatahui, tapi ada beberapa faktor yang memiliki peran dalam gangguan ini, seperti faktor genetik, komplikasi kehamilan dan persalinan dan faktor kimia pada otak";
            }

            if (name == "OCD")
            {
                TextDescription.GetComponent<Text>().text =
                    "OCD ditandai dengan adanya obsesi dan atau kompulsi.Obsesi merupakan pemikiran atau desakan yang berulang yang membuat seseorang tidak nyaman, sedangkan kompulsi merupakan perilaku yang berulang atau tindakan yang dilakukan seseorang karena merasa terdorong untuk menanggapi obsesi atau pola yang sudah ada." + "\n" + "\n" +
                    "Gejala" + "\n" + "\n" +
                    "Obsesi" + "\n" +
                    "- Takut terhadap kontaminasi kuman" + "\n" +
                    "- Takut kehilangan sesuatu" + "\n" +
                    "- Kekhawatiran tentang bahaya" + "\n" +
                    "- Membutuhkan hal - hal diatur dengan cara tertentu dan tepat" + "\n" + "\n" +
                    "Kompulsi" + "\n" +
                    "- Pembersihan atau cuci tangan yang berlebihan" + "\n" +
                    "- Memeriksa hal - hal berulang kali, seperti pintu terkunci" + "\n" +
                    "-Mengatur sesuatu dengan cara tertentu dan tepat" + "\n" + "\n" +
                    "Penyebab gangguan obsesif - kompulsif(OCD) tidak diketahui. namun ada faktor - faktor seperti genetik, biologi otak dan kimia, dan lingkungan." + "\n" +
                    "OCD dapat dirawat dengan:" + "\n" +
                    "-Terapi kognitif perilaku/ Cognitive behavioral Therapy(CBT)" + "\n" +
                    "-Obat - obatan seperti antidepressant";
            }

            if (name == "Anxiety")
            {
                TextDescription.GetComponent<Text>().text = "Gangguan ini memiliki ciri khas seperti ketakutan dan kecemasan yang berlebihan yang tidak hilang.  ketakutan merupakan respon emosional kita terhadap ancaman yang nyata sedangkan rasa cemas merupakan antisipasi ancaman yang mungkin terjadi. " + "\n" +
                    "gejala dari gangguan ini dapat mengganggu aktivitas kita seperti pekerjaan atau hubungan kita dengan orang lain." +"\n" +
                    "Ada beberapa tipe dari Anxiety Disorder yaitu:" + "\n" +
                    "a.Generalized anxiety disorder(GAD)" + "\n" +
                    "b.Panic Disorder" + "\n" +
                    "c. Phobia" + "\n" + "\n" +
                    "Gejala" + "\n" +
                    "- Pikiran cemas dyang susah di kontrol" + "\n" +
                    "- Detak jantung berdebar dan pusing serta sesak napas" + "\n" +
                    "Penyebab pasti gangguan ini belum diketahui namun ada faktor seperti, kecanduan, kejadian traumatis, genetik, atau biologi otak." + "\n" + "\n" +
                    "Anxiety disorder dapat dirawat dengan:" + "\n" +
                    "-Terapi kognitif perilaku/ Cognitive behavioral Therapy(CBT)" + "\n" +
                    "-Obat - obatan seperti obat anti cemas dan antidepressant";
            }

            if (name == "ADHD")
            {
                TextDescription.GetComponent<Text>().text = "Orang yang memiliki gangguan ini sulit untuk memusatkan fokusnya(inatensi) pada satu aktivitas serta memiliki perilaku hiperaktif dan impulsif. Biasanya kondisi dimulai pada masa kanak-kanak." + "\n" + "\n" +
                    "Gejala" + "\n" +
                    "a.Intensi" + "\n" +
                    "contohnya seperti mudah terganggu atau susah fokus, pelupa, atau tidak bisa menyelesaikan tugas" + "\n" +
                    "b.Hiperaktif" + "\n" +
                    "contohnya seperti rasa semangat yang berlebih, sulit mengunggu dan tidak dapat duduk tenang" + "\n" +
                    "c.Impulsif" + "\n" +
                    "memiliki sifat yang tidak hati-hati dan menghiraukan konsekuensi" + "\n" + "\n" +
                    "Penyebab pasti gangguan ini belum diketahui namun ada faktor seperti genetik dan pengaruh lingkungan" + "\n" + "\n" +
                    "ADHD dapat dirawat dnegan" + "\n" +
                    "- Terapi kognitif perilaku/ Cognitive behavioral Therapy(CBT)" + "\n" +
                    "-Terapi Psikologi" + "\n" +
                    "- Pelatihan interaksi sosial" + "\n" +
                    "-Obat - obatan";
            }


        }
    }

    void playSound(string ss)
    {
        clipTarget = (AudioClip)Resources.Load(ss);
        soundTarget.clip = clipTarget;
        soundTarget.loop = false;
        soundTarget.playOnAwake = false;
        soundTarget.Play();
    }
}
