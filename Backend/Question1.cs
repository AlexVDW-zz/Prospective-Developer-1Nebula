public string Likes(List<string> usersLiked)
{
        var numUsersLiked = usersLiked.Count;
        
        if(numUsersLiked == 1)
        {
            return $"{usersLiked[0]} likes this";
        }
        else if (numUsersLiked == 2)
        {
            return $"{usersLiked[0]} and {usersLiked[1]} like this";
        }
        else if (numUsersLiked == 3)
        {
            return $"{usersLiked[0]}, {usersLiked[1]} and {usersLiked[2]} like this";
        }
        else if (numUsersLiked >= 4)
        {
            return $"{usersLiked[0]}, {usersLiked[1]} and {numUsersLiked - 2} others like this";
        }

        return "no one likes this";
}