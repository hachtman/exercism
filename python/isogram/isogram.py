def is_isogram(string):
    arr = []
    for char in list(string.lower()):
        if char in arr and char.isalpha():
            return False
        arr.append(char)
    return True


# count for each letter. If any letter higher than one, return false