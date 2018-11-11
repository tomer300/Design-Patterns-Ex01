using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using System.ComponentModel;
using static FacebookWrapper.ObjectModel.User;

namespace MyFacebookApp.Model
{
	public class Match
	{
		private readonly FacebookObjectCollection<AppUser> r_UserFriends;
		public Match(FacebookObjectCollection<AppUser> i_UserFriends)
		{
			r_UserFriends = i_UserFriends;
		}

		internal FacebookObjectCollection<AppUser> FindAMatch(bool i_ChoseGirls, bool i_ChoseBoys, string i_AgeRange)
		{
			FacebookObjectCollection<AppUser> potentialMatches = new FacebookObjectCollection<AppUser>();

			foreach (AppUser currentPotentialMatch in r_UserFriends)
			{
				if (isUserWithinChosenAgeRange(currentPotentialMatch, i_AgeRange) && isUserSingle(currentPotentialMatch))
				{
					if ((!i_ChoseBoys && !i_ChoseGirls) || (i_ChoseBoys && i_ChoseGirls))
					{
						potentialMatches.Add(currentPotentialMatch);
					}
					else
					{
						eGender? userGender = currentPotentialMatch.GetGender();
						if (userGender != null)
						{
							if (i_ChoseBoys && userGender == eGender.male)
							{
								potentialMatches.Add(currentPotentialMatch);
							}
							else if (i_ChoseGirls && userGender == eGender.female)
							{
								potentialMatches.Add(currentPotentialMatch);
							}
						}
					}
				}
			}

			return potentialMatches;
		}

		private bool isUserSingle(AppUser i_CurrentPotentialMatch)
		{
			bool isSingle = false;
			try
			{
				eRelationshipStatus? userRelationshipStatus = i_CurrentPotentialMatch.GetRelationshipStatus();
				if (userRelationshipStatus != null)
				{
					if(userIsReadyForRelationship(userRelationshipStatus))
					{
						isSingle = true;
					}
				}
			}
			catch(Exception ex)
			{
				throw new Facebook.FacebookApiException(ex.Message);
			}

			return isSingle;
		}

		private bool userIsReadyForRelationship(eRelationshipStatus? i_UserRelationshipStatus)
		{
			bool isReadyForRelationship = false;

			if(i_UserRelationshipStatus != eRelationshipStatus.InACivilUnion &&
				i_UserRelationshipStatus != eRelationshipStatus.InADomesticPartnership &&
				i_UserRelationshipStatus != eRelationshipStatus.InARelationship &&
				i_UserRelationshipStatus != eRelationshipStatus.Married)
			{
				isReadyForRelationship = true;
			}

			return isReadyForRelationship;
		}

		private bool isUserWithinChosenAgeRange(AppUser i_User, string i_AgeRange)
		{
			/*the age range options are: 
										18-20
										21-25
										26-30
										31-35
										36-40
										41-45
										46-50
										50+
			*/
			const int SINGLE_BOUND = 1, LOWER_BOUND = 0, UPPER_BOUND = 1;
			const char RANGE_DELIMITER = '-', ABOVE_DELIMITER = '+';
			string[] chosenRange = i_AgeRange.Split(RANGE_DELIMITER, ABOVE_DELIMITER);
			bool iswithinRange = false;
			int usersAge;
			try {
				usersAge = calculateAge(i_User.GetBirthday());

				if (chosenRange.Length == SINGLE_BOUND)
				{
					if (usersAge > int.Parse(chosenRange[LOWER_BOUND]))
					{
						iswithinRange = true;
					}
				}
				else
				{
					if (usersAge >= int.Parse(chosenRange[LOWER_BOUND]) && usersAge <= int.Parse(chosenRange[UPPER_BOUND]))
					{
						iswithinRange = true;
					}

				}
			}
			catch (Exception ex)
			{
				//since isUserWithinChosenAgeRange is being used within a foreach loop we chose that if someone has no birthday he just wont
				//be included as a match option.
			}

			return iswithinRange;

		}

		private int calculateAge(string i_Birthday)
		{
			const int MONTH = 0, DAY = 1, YEAR = 2;
			const char DATE_DELIMITER = '/';
			int age = 0;
			string[] birthDateArray = i_Birthday.Split(DATE_DELIMITER);
			DateTime birthDate;
			DateTime today = DateTime.Today;
			if(birthDateArray!=null)
			{
				try
				{
					birthDate = new DateTime(int.Parse(birthDateArray[YEAR]), int.Parse(birthDateArray[MONTH]), int.Parse(birthDateArray[DAY]));
					age = today.Year - birthDate.Year;
					if (birthDate > today.AddYears(-age))
					{
						age--;
					}
				}
				catch(Exception ex)
				{
					throw new Exception("Cannot parse in calculate age");
				}
			}
			else
			{
				throw new FormatException("Invalid formatted string in calculate age");
			}
			


			return age;
		}

	}
}

	

