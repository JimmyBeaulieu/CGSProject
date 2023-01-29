using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Struct
{
    internal class Program
    {
        struct Curator
        {
            public string curatorID;
            public string firstname;
            public string lastname;
            public double commission; // = 0.0
        }

        struct Artist
        {
            public string artistID;
            public string curatorID;
            public string firstname;
            public string lastname;
        }

        struct Artpiece
        {
            public string artpieceID;
            public string curatorId;
            public string artistID;
            public string title;
            public int year;
            public double value;
            public double estimate; // = 0.0
            public char status; // = 'D'
        }

        static Curator[] myCurators = new Curator[10];
        static Artist[] myArtists = new Artist[10];
        static Artpiece[] myArtpieces = new Artpiece[10];

        static int index_curator = 0;
        static int index_artist = 0;
        static int index_artpiece = 0;

        static bool checkCuratorID(string curatorID)
        {
            bool flag = false;
            for (int i = 0; i < myCurators.Length; i++)
            {
                if (myCurators[i].curatorID == curatorID)
                {
                    flag = true;
                }
            }
            return flag; ;
        }


        static void addCurator()
        {
            Console.WriteLine("Please enter curator ID: ");
            string curatorID = Console.ReadLine();
            if(curatorID.Length != 5)
            {
                Console.WriteLine("Must be 5 characters");
            }
            else
            {
                if(checkCuratorID(curatorID) == true)
                {
                    Console.WriteLine("Error! ID already exists");
                }
                else
                {
                    Console.WriteLine("Please enter firstname: ");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Please enter lastname: ");
                    string lastname = Console.ReadLine();
                    if(firstname.Length + lastname.Length > 40 )
                    {
                        Console.WriteLine("Error. Must be 40 char max");
                    }
                    else
                    {
                        myCurators[index_curator].curatorID = curatorID;
                        myCurators[index_curator].firstname = firstname;
                        myCurators[index_curator].lastname = lastname;
                        myCurators[index_curator].commission = 0.0;
                        index_curator++;
                        Console.WriteLine("Success! Curator added");
                        Console.WriteLine("==============================");
                    }

                }
            }
        }

        static bool checkArtistID(string artistID)
        {
            bool flag = false;
            for (int i = 0; i < myArtists.Length; i++)
            {
                if (myArtists[i].artistID == artistID)
                {
                    flag = true;
                }
            }
            return flag; ;
        }
        static void addArtist()
        {
            Console.WriteLine("Please add artist ID: ");
            string artistID = Console.ReadLine();
            if (artistID.Length != 5)
            {
                Console.WriteLine("Must be 5 characters");
            }
            else
            {
                if(checkArtistID(artistID) == true)
                {
                    Console.WriteLine("Error! ID already exists");
                }
                else
                {
                    Console.WriteLine("Please enter curatorID: ");
                    string curatorID = Console.ReadLine();
                    if (checkCuratorID(curatorID) == true)
                    {
                        Console.WriteLine("Error! ID already exists");
                    }
                    else
                    {
                        Console.WriteLine("Please enter firstname: ");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Please enter lastname: ");
                        string lastname = Console.ReadLine();
                        if (lastname.Length + firstname.Length > 40)
                        {
                            Console.WriteLine("Error! Must be 40 characters maximum");
                        }
                        else
                        {
                            myArtists[index_artist].artistID = artistID;
                            myArtists[index_artist].curatorID = curatorID;
                            myArtists[index_artist].firstname = firstname;
                            myArtists[index_artist].lastname = lastname;
                            index_artist++; 
                        }
                    }                   
                }
            }
        }

        static bool checkArtpieceID(string artpieceID)
        {
            bool flag = false;
            for(int i = 0; i < myArtpieces.Length; i++)
            {
                if (myArtpieces[i].artpieceID == artpieceID)
                {
                    flag = true;
                }
            }
            return flag;
        }
        static void addArtpiece()
        {
            Console.WriteLine("Please enter ArpieceID: ");
            string artpieceID = Console.ReadLine();
            if (artpieceID.Length != 5)
            {
                Console.WriteLine("Error! Must be 5 characters");
            }
            else
            {
                if (checkArtpieceID(artpieceID) == true)
                {
                    Console.WriteLine("Error! ID already exists");
                }
                else
                {
                    Console.WriteLine("Please enter curator ID: ");
                    string curatorID = Console.ReadLine();
                    if (curatorID.Length != 5)
                    {
                        Console.WriteLine("Error! Must be 5 characters");
                    }
                    else
                    {
                        if (checkCuratorID(curatorID) == false)
                        {
                            Console.WriteLine("Error! ID does not exist");
                        }
                        else
                        {
                            Console.WriteLine("Please enter artist ID: ");
                            string artistID = Console.ReadLine();
                            if (artistID.Length != 5)
                            {
                                Console.WriteLine("Error! Must be 5 characters");
                            }
                            else
                            {
                                if (checkArtistID(artistID) == false)
                                {
                                    Console.WriteLine("Error! ID does not exist");
                                }
                                else
                                {
                                    Console.WriteLine("Please enter artpiece title: ");
                                    string title = Console.ReadLine();
                                    Console.WriteLine("Please enter year of artpiece: ");
                                    int year = Convert.ToInt32(Console.ReadLine());
                                    if (year.ToString().Length != 4)
                                    {
                                        Console.WriteLine("Error! Must be 4 digits");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter value: ");
                                        double value = Convert.ToDouble(Console.ReadLine());
                                        myArtpieces[index_artpiece].artpieceID = artpieceID;
                                        myArtpieces[index_artpiece].curatorId = curatorID;
                                        myArtpieces[index_artpiece].artistID = artistID;
                                        myArtpieces[index_artpiece].title = title;
                                        myArtpieces[index_artpiece].year = year;
                                        myArtpieces[index_artpiece].estimate = 0.0;
                                        myArtpieces[index_artpiece].status = 'D';
                                        index_artpiece++;
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }

        static bool statusVerifier(string artpieceID)
        {
            bool flag = false;
            for (int i = 0; i < myArtpieces.Length; i++)
            {
                if(myArtpieces[i].artpieceID == artpieceID)
                {
                    if (myArtpieces[i].status == 'S')
                    {
                        flag = true;
                    }
                }
            }
            return flag;
        }

        static double getValueOfArtpiece (string artpieceID)
        {
            double value = 0.0;
            for (int i = 0; i < myArtpieces.Length; i++)
            {
                if (myArtpieces[i].artpieceID == artpieceID)
                {
                    myArtpieces[i].value = value;
                }
            }
            return value;
        }

        static void changeStatusToSold(string artpieceID)
        {
            for (int i = 0; i < myArtpieces.Length; i++)
            {
                if (myArtpieces[i].artpieceID == artpieceID)
                {
                    myArtpieces[i].status = 'S';
                }
            }
        }

        static string getCuratorIdFromArtpieceID(string artpieceID)
        {
            string curatorID = null;
            for (int i = 0; i < myArtpieces.Length; i++)
            {
                if (myArtpieces[i].artpieceID == artpieceID)
                {
                    myArtpieces[i].curatorId = curatorID;
                }
            }
            return curatorID;
        }

        static double setCommission(string curatorID, double value, double estimate)
        {
            double commission = 0.0;
            commission = (estimate - value) * 0.10;
            for (int i = 0; i < myCurators.Length; i++)
            {
                if (myCurators[i].curatorID == curatorID)
                {
                    myCurators[i].commission = commission;
                }
            }
            return commission;
        }

        static void setEstimate(string artPieceId, double estim)
        {
            for (int i = 0; i < myArtpieces.Length; i++)
            {
                if(myArtpieces[i].artpieceID == artPieceId)
                {
                    myArtpieces[i].estimate = estim;   
                }
                
            }
        }

        static void sellPiece()
        {
            Console.WriteLine("Please, enter artpiece ID: ");
            string artPieceID = Console.ReadLine();   
            if (checkArtpieceID(artPieceID) == false)
            {
                Console.WriteLine("Error! artpiece ID does not exist");
            }
            else
            {
                if(statusVerifier(artPieceID) == true)
                {
                    Console.WriteLine("Error! Artpiece is already tagged as Sold");
                }
                else
                {
                    Console.WriteLine("Please enter price (estimate): ");
                    double estimate = Convert.ToDouble(Console.ReadLine());
                    double value = getValueOfArtpiece(artPieceID);    
                    if (estimate < value)
                    {
                        Console.WriteLine("Error! The entered price is under the value");
                    }
                    else
                    {
                        changeStatusToSold(artPieceID);
                        string curatorID = getCuratorIdFromArtpieceID(artPieceID);
                        setCommission(curatorID, value, estimate);
                        setEstimate(artPieceID, estimate);
                        Console.WriteLine("Success! Artpiece " + artPieceID + " is now sold\n");
                    }
                }
            }
        }


        static void Main(string[] args)
        {
        
        }
    }
}
