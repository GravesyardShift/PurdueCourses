#! /bin/bash
echo "This script will check if a username has been taken yet and provide an alternative if taken."
read -p "Enter the username you want to check: " answer

if id "$answer" &>/dev/null;
then 
    echo "$answer is not available!"
    answer+="1"
    if ! id "$answer" &>/dev/null;
    then
        echo "$answer is available though"
    fi
else
    echo "$answer is available!"
fi