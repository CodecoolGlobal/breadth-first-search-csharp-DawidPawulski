using System.Collections.Generic;

namespace BFS_c_sharp.Model
{
    public class UserNode
    {
        private int distanceCounter = 1;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private readonly HashSet<UserNode> _friends = new HashSet<UserNode>();
        public HashSet<UserNode> Friends
        {
            get { return _friends; }
        }


        public UserNode() { }

        public UserNode(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddFriend(UserNode friend)
        {
            Friends.Add(friend);
            friend.Friends.Add(this);
        }

        public int DistanceBetweenTwoUsers(UserNode firstFriend, UserNode secondFriend)
        {
            bool flag = true;
            UserNode currentFriend = firstFriend;
            while (flag)
            {
                if (currentFriend.Friends.Count > 0)
                {
                    foreach(var friend in currentFriend.Friends)
                    {
                        if(friend.FirstName == secondFriend.FirstName && friend.LastName == secondFriend.LastName)
                        {
                            return distanceCounter;
                        }
                        else
                        {

                            distanceCounter++;
                        }
                    }
                }
                else
                {
                    flag = false;
                }
            }
            return distanceCounter;
        }

        public void DistanceRec(UserNode current, UserNode searched)
        {
            
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + "(" + Friends.Count + ")";
        }
    }
}
