using System;

namespace Assignment2 {
public record ImmutableStudent(int id, string GivenName, string Surname, Status status) {
    private int id { get; init; } = id;
    public string GivenName { get; init; } = GivenName;
    string Surname { get; init; } = Surname;
    public Status status { get; init; } = status;
    DateTime StartDate { get; init; }
    DateTime EndDate { get; init; }
    DateTime GraduationDate { get; init; }

   
}
}