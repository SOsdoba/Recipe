alter table Cookbooks add CookbookSkill int default 1
go
alter table Cookbooks add CookbookSkillDesc as 
	CASE 
		when CookbookSkill = 1 then 'Beginner'
		when CookbookSkill = 2 then 'Intermediate'
		when CookbookSkill = 3 then 'Advanced'
	END
