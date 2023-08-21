CREATE TABLE Influencers (
InfluencerID int NOT NULL,
Name varchar (255) NOT NULL,
InstagramFollowers int NOT NULL ,
Age int
PRIMARY KEY (InfluencerID)
);
CREATE TABLE SocialMediaPlatfrom (
PlatformID int NOT NULL,
Name varchar (255) NOT NULL,
AvgUserAge float,
TotalUser int NOT NULL,
PRIMARY KEY (PlatformID)
);
CREATE TABLE Brands (
BrandID int NOT NULL,s
Name varchar (255) NOT NULL,
Catagory varchar (255) NOT NULL,
PRIMARY KEY (BrandID)
);

CREATE TABLE Collaborations (
CollaborationID int NOT NULL,
InfluencerID int FOREIGN KEY REFERENCES Influencers(InfluencerID),
BrandID int FOREIGN KEY REFERENCES Brands(BrandID),
PlatformID int FOREIGN KEY REFERENCES SocialMediaPlatFrom(PlatformID),
Duration int NOT NULL,
Payment float

);
