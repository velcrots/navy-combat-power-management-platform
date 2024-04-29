main(master) 브랜치는 현재 배포가능한 버전으로 유지  
  
develop 브랜치에서는 여러 기능들을 개발한 각각 브랜치들을 merge 하여  
배포가능한 버전이 되면 main(master)에 merge  
  
feature 브랜치에서는 develop에서 분기하여 개발하고 있는 기능들  
브랜치 이름은 "feature/기능요약"을 추천  
브랜치가 너무 많아질 수 있으므로 개발 완료하면 브랜치 삭제  
  
hotfix 브랜치에서는 main(master) 브랜치에서 버그 발견시 분기하여 빠르게 수정  
수정 내용은 main(master)랑 develop 브랜치에 merge  
브랜치 이름은 "hotfix-버전명"을 추천  
  