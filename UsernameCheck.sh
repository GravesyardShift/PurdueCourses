#! /bin/bash
echo "This script will check if a username has been taken yet and provide an alternative if taken."
read -p "Enter the username you want to check: " usernamerequest

if ! id "$usernamerequest" &>/dev/null;
then 
    echo "$usernamerequest is available!"
else
    echo "$usernamerequest is not available!"
    
    while id "$usernamerequest" &>/dev/null;
    do
        usernamerequest+="1"
    done
    echo "$usernamerequest is available though"
fi
