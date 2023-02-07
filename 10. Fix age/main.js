function fixage(array) {
    const filteredAge = array.filter((age) => age >= 18 && age <= 60);
    
    if (filteredAge.length === 0) {
        return "NA";
    } else {
        return filteredAge.join(",");
    }
}