/*
04. Файлове без директории
Някои от файловете са директории, защото те са родител на някой файл. 
Опитайте се да намерите тези, които не са.
Извличане от базата данни на всички файлове, които НЕ са родител на друг файл.
Извлечете размера на файла и добавете "KB" в края му.
Подредете резултатите във възходящ ред по id на файла.
*/
SELECT id,`name`,CONCAT(size,"KB") as "size"
FROM files
WHERE id NOT IN 
(
	SELECT DISTINCT parent_id 
	FROM files 
	WHERE parent_id IS NOT NULL
)
ORDER BY id;




